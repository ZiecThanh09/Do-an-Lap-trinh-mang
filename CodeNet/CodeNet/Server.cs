using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Net.Sockets;
using System.Data.SqlClient;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DangNhap
{
    public partial class Server : Form
    {
        string userName, password, task, signal, content;
        string mkTV;
        string notify;
        string textTDN = "";
        Modify modify = new Modify();
        private Socket sock = null;

        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLTaiKhoan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public Server()
        {
            InitializeComponent();
        }

        void loadData(string query)
        {
            command = new SqlCommand(query, connection);
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvRoomList.DataSource = table;
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(listenerThread));
            serverThread.Start();
        }

        public byte[] SerializeData(Object o)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(ms, o);
            return ms.ToArray();
        }

        Socket socket()
        {
            return new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
        }

        private Socket serverSocket;
        private void listenerThread()
        {
            serverSocket = socket();
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            serverSocket.Bind(ipe);
            serverSocket.Listen(-1);
            btnListen.Enabled = false;
            while (true)
            {
                Socket clientSocket = serverSocket.Accept();              
                while (clientSocket.Connected)
                {
                    int bytes = 0;
                    byte[] bytesReceived = new byte[1];
                    string Nhan = "";
                    do
                    {
                        bytes = clientSocket.Receive(bytesReceived);
                        Nhan += Encoding.ASCII.GetString(bytesReceived);
                    }
                    while (Nhan[Nhan.Length - 1] != '\n');

                    if (Nhan == "q\n")
                    {
                        clientSocket.Close();
                        break;
                    }
                    else
                    {
                        string[] arr = Nhan.Split(new char[] { ':' });
                        signal = arr[0];
                        content = arr[1];
                    }

                    if (signal == "Binhdan")
                    {
                        string temp = "BinhDan";
                        string query = "select * from DANHSACHPHONG where LOAIBAN = '" + temp + "'";
                        connection = new SqlConnection(str);
                        loadData(query);
                        send_Serial();
                        notify = "e";
                        byte[] data = Encoding.ASCII.GetBytes(notify);
                        clientSocket.Send(data);
                        clientSocket.Close();
                    }

                    if (signal == "tp")
                    {
                        string[] arrCP = content.Split(new char[] { ',' });
                        string chuphong = arrCP[0];
                        string[] arrLB = arrCP[1].Split(new char[] { '.' });
                        string LoaiBan = arrLB[0];
                        string MatKhau = arrLB[1];
                        Random random = new Random();
                        int id = random.Next(1000, 9999);
                        int i = 1;
                        string query = "Insert into DANHSACHPHONG values ('" + id + "','" + chuphong + "','" + LoaiBan + "','" + MatKhau + "','" + i + "')";
                        modify.Command(query);
                        string notify = "taophong" + "." + chuphong + "," + id + "\n";
                        byte[] data = Encoding.ASCII.GetBytes(notify);
                        clientSocket.Send(data);
                        clientSocket.Close();
                    }

                    if (signal == "dkdn")
                    {
                        textTDN = content;
                        string[] arrDkDn = textTDN.Split(new char[] { ',' });
                        userName = arrDkDn[0];
                        mkTV = arrDkDn[1];
                        string[] ar = mkTV.Split(new char[] { '.' });
                        password = ar[0];
                        task = ar[1];
                        tbTest.Text += userName + " " + password + " " + task;

                        // TrẢ VỀ THÔNG TIN ĐĂNG KÍ , ĐĂNG NHẬP 
                        if (task == "dn\n")
                        {
                            bool ktdn = checkSignIn(userName, password);
                            if (ktdn == true)
                            {
                                notify = "a";
                                byte[] data = Encoding.ASCII.GetBytes(notify);
                                clientSocket.Send(data);
                                clientSocket.Close();
                            }
                            else
                            {
                                notify = "b";
                                byte[] data = Encoding.ASCII.GetBytes(notify);
                                clientSocket.Send(data);
                                clientSocket.Close();
                            }

                        }
                        else if (task == "dk\n")
                        {
                            bool ktdk = checkSignUp(userName, password);

                            if (ktdk == true)
                            {
                                string notify = "c";
                                byte[] data = Encoding.ASCII.GetBytes(notify);
                                clientSocket.Send(data);
                            }
                            else
                            {
                                string notify = "d";
                                byte[] data = Encoding.ASCII.GetBytes(notify);
                                clientSocket.Send(data);
                            }
                            clientSocket.Close();
                        }
                    }

                    if (signal == "TimPhong")
                    {



                    }
                }
            }
        }
        
        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serverSocket != null)
            {
                serverSocket.Close();
            }
        }

        /*public bool Kiemtraphong(int id)
        {
            string query = "select * from DANHSACHPHONG where IDPHONG='" + id + "'";
            if (modify.Phongs(query).Count != 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }*/

        public void send_Serial()
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread BDThread = new Thread(new ThreadStart(BinhdanThread));
            BDThread.Start();
           
          
        }
        private void BinhdanThread()
        {
            IPEndPoint ipEnd = new IPEndPoint(IPAddress.Any, 5656);

            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            sock.Bind(ipEnd);

            sock.Listen(10);
            while (true)
            {
                Socket clSocket = sock.Accept();
               ////while (clSocket.Connected)
               // {
                clSocket.Send(SerializeData(table));
                clSocket.Close();
               // }
            }

        }

        public bool checkSignIn (string user,string pass)
        {
            string query = "select * from DULIEUTAIKHOAN where TENDANGNHAP='" + user + "' and MATKHAU='" + pass + "'";
            if (modify.Account(query).Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool checkSignUp(string user, string pass)
        {
            try
            {
                string query = "Insert into DULIEUTAIKHOAN values ('" + user + "','" + pass + "')";
                modify.Command(query);
                return true;
            }
            catch { return false; }
        }     

        /*private void btnNgheLDS_Click(object sender, EventArgs e)
        {
            IPEndPoint ipEnd = new IPEndPoint(IPAddress.Any, 5656);
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            
            sock.Bind(ipEnd);
            sock.Listen(100);
            btnNgheLDS.Enabled = false;
            Socket clientSock = sock.Accept();            
            clientSock.Send(SerializeData(table));
            sock.Close();
            clientSock.Close();
        }*/
    }
}

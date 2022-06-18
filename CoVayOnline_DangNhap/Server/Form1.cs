using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using General;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Net.Sockets;
using System.Data.SqlClient;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace Server
{
    public partial class Form1 : Form
    {
        string userName, password, task, signal, content;
        string mkTV;
        string notify;
        string textTDN = "";
        Modify modify = new Modify();
        private Socket sock = null;
        private Socket sock_Bd = null;
        private Socket sock_Ct = null;

        SqlConnection connection;
        SqlCommand command;
        string link = @"Data Source=MSI\MISASME2017;Initial Catalog=QLTaiKhoan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        private class bdata
        {
            public byte[] data = new byte[1024];
        }
        Socket server,skclient;
        IPEndPoint ipee;
        List<Player> player = new List<Player>();
        
        List<Room> phong = new List<Room>();
        Thread thclient;
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //CheckForIllegalCrossThreadCalls = false;
               // Thread serverThread = new Thread(new ThreadStart(listenerThread));
                //serverThread.Start();
                


                ipee = new IPEndPoint(IPAddress.Any, 9124);
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                server.Bind(ipee);
                server.Listen(-1);

                Thread thserver = new Thread(new ThreadStart(LangNgheClient));
                thserver.IsBackground = true;
                thserver.Start();

                button1.Visible = false;
                button3.Visible = true;

                AppendTextThongBao("Sẵn Sàng Lằng Nghe Kết Nối Từ Client");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        Socket socket()
        {
            return new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
        }
        private Socket serverSocket;
        private void listenerThread()
        {
            serverSocket = socket();
            IPEndPoint ipe = new IPEndPoint(IPAddress.Any, 9124);
            serverSocket.Bind(ipe);
            serverSocket.Listen(-1);
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
                    
                    if (signal == "dkdn")
                    {
                        textTDN = content;
                        string[] arrDkDn = textTDN.Split(new char[] { ',' });
                        userName = arrDkDn[0];
                        mkTV = arrDkDn[1];
                        string[] ar = mkTV.Split(new char[] { '.' });
                        password = ar[0];
                        task = ar[1];
                        

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
                            task = "";
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
                            task = "";
                            clientSocket.Close();
                        }
                    }


                }
            }
        }
        public bool checkSignIn(string user, string pass)
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
        private void AppendTextThongBao(string s)
        {
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.AppendText(s);
            richTextBox1.ScrollToCaret();
        }
        private void LangNgheClient()
        {

            
            while (true)
            {
                try
                {   

                    skclient = server.Accept();
                    int bytes = 0;
                    byte[] bytesReceived = new byte[1];
                    string Nhan = "";
                    do
                    {
                        bytes = skclient.Receive(bytesReceived);
                        Nhan += Encoding.ASCII.GetString(bytesReceived);
                    }
                    while (Nhan[Nhan.Length - 1] != '\n');

                    if (Nhan == "q\n")
                    {
                        skclient.Close();
                        break;
                    }
                    else
                    {
                        string[] arr = Nhan.Split(new char[] { ':' });
                        signal = arr[0];
                        content = arr[1];
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


                        // TrẢ VỀ THÔNG TIN ĐĂNG KÍ , ĐĂNG NHẬP 
                        if (task == "dn\n")
                        {
                            bool ktdn = checkSignIn(userName, password);
                            if (ktdn == true)
                            {
                                Player pl = new Player();
                                pl.socket = skclient;
                                pl.ipaddress = pl.socket.RemoteEndPoint.ToString();
                                player.Add(pl);

                                thclient = new Thread(LangNgheClientMoi);
                                thclient.IsBackground = true;
                                thclient.Start(pl);

                                richTextBox1.SelectionColor = Color.Blue;
                                richTextBox1.AppendText("\nChấp Nhận kết nối từ " + pl.socket.RemoteEndPoint.ToString());
                                richTextBox1.ScrollToCaret();


                                notify = "a";
                                byte[] data = Encoding.ASCII.GetBytes(notify);
                                skclient.Send(data);
                                //skclient.Close();
                            }
                            else
                            {
                                notify = "b";
                                byte[] data = Encoding.ASCII.GetBytes(notify);
                                skclient.Send(data);
                                skclient.Close();
                            }
                            task = "";
                        }
                        else if (task == "dk\n")
                        {
                            bool ktdk = checkSignUp(userName, password);

                            if (ktdk == true)
                            {
                                string notify = "c";
                                byte[] data = Encoding.ASCII.GetBytes(notify);
                                skclient.Send(data);
                            }
                            else
                            {
                                string notify = "d";
                                byte[] data = Encoding.ASCII.GetBytes(notify);
                                skclient.Send(data);
                            }
                            task = "";
                            skclient.Close();
                        }
                    }


                    
                }
                catch
                {
                    
                }
            }
        }
        string str;
        string[] a_str;
        int recv;

        bdata bb = new bdata();
        private void LangNgheClientMoi(object obj)
        {
            Player ple = (Player)obj;
            while (true)
            {
                try
                {
                    recv=ple.socket.Receive(bb.data);
                    str = Encoding.Unicode.GetString(bb.data,0,recv);
                    a_str = str.Split('|');
                    bdata dd = new bdata();
                    dd.data = Encoding.Unicode.GetBytes(str);
                    LangNgheClient2(a_str[0], dd.data, ple);
                }
                catch
                {

                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.AppendText("\n" + ple.socket.RemoteEndPoint.ToString() + " Đã Đóng Kết Nối");
                    richTextBox1.ScrollToCaret();

                    player.Remove(ple);

                    break;
                }
            }
        }
        private void LangNgheClient2(string s, byte[] data, Player ple)
        {
            switch (s)
            {
                case "DANHCARO":
                    DanhCaRo(str, data, ple);
                    break;
                case "CHAT":
                    SendAllClient(data);
                    break;
                case "CHATPHONG":
                    chatphong(data, ple);
                    break;
                case "WINNER":
                    Winner(str, data,ple);
                    break;
                case "NAMECLIENT":
                    setnameclient(str,ple);
                    break;
                case "TAOPHONGMOI":
                    taophongmoi(str, ple);
                    break;
                case "LAYIDPHONG":
                    layidphong(ple);
                    break;
                case "LAYDANHSACHPHONG":
                    laydanhsachphong(ple);
                    break;
                case "VAOPHONGGAME":
                    vaophong(str,ple);
                    break;
                case "THOATKHOIPHONGGAME":
                    thoatphonggame(str,data,ple);
                    break;
            }
        }
        private void thoatphonggame(string str,byte[] data,Player ple)
        {
            a_str = str.Split(',');
            if (int.Parse(a_str[1]) == 2)
            {
                if (ple.room.siso == 2)
                {
                    Room r = ple.room;
                    data=Encoding.Unicode.GetBytes("BANLACHUPHONG|,"+"Người Chơi "+r.plnguoichoi1.name+" Đã thoát,");
                    r.plnguoichoi2.socket.Send(data, data.Length, SocketFlags.None);
                    r.plnguoichoi1 = r.plnguoichoi2;
                    r.plnguoichoi2 = null;
                    r.siso = 1;
                    ple.room.plnguoichoi1.room = r;
                }
                else
                {
                    phong.Remove(ple.room);
                    ple.room = null;
                }
            }
            else
            {
                if (ple.room.siso == 2)
                {
                    Room r = ple.room;
                    data = Encoding.Unicode.GetBytes("BANLACHUPHONG|," + "Người Chơi " + r.plnguoichoi2.name + " Đã thoát,");
                    r.plnguoichoi1.socket.Send(data, data.Length, SocketFlags.None);
                    r.siso = 1;
                    r.plnguoichoi2 = null;
                    r.plnguoichoi1.room = r;
                }
                else
                {
                    phong.Remove(ple.room);
                    ple.room = null;
                }
            }

        }
        private void vaophong(string str,Player ple)
        {
            a_str = str.Split(',');
            int idphong = int.Parse(a_str[1]);
            Player plr = timphong(idphong);
            bdata b = new bdata();
            Room r=plr.room;
            if (r.siso == 1)
            {
                r.siso = 2;
                r.plnguoichoi2 = ple;
                ple.room = r;
                plr.room = r;
                b.data = Encoding.Unicode.GetBytes("NGUOICHOIMOIVAOPHONG|," + r.plnguoichoi2.name + ",");
                plr.socket.Send(b.data, b.data.Length, SocketFlags.None);
            }
            else
            {
                b.data = Encoding.Unicode.GetBytes("PHONGDADAY|,");
                ple.socket.Send(b.data, b.data.Length, SocketFlags.None);
            }
        }
        private Player timphong(int idphong)
        {
            foreach (Player plr in player)
            {
                if (plr.room.sophong == idphong)
                {
                    return plr;
                }
            }
            return null;
        }
        private void laydanhsachphong(Player ply)
        {
            if (phong.Count > 0)
            {
                byte[] data=new byte[1024];
                string danhsachphong = "DANHSACHPHONGGAME|,";
                foreach (Room r in phong)
                {
                    danhsachphong += r.sophong+"\t("+r.siso + "/2),";
                }
                data = Encoding.Unicode.GetBytes(danhsachphong);
                ply.socket.Send(data, data.Length, SocketFlags.None);
            }
        }
        private void layidphong(Player ple)
        {
            bdata b = new bdata();
            b.data = Encoding.Unicode.GetBytes("IDPHONGGAME|," +ple.room.sophong +",");
            ple.socket.Send(b.data, b.data.Length, SocketFlags.None);
        }
        private void taophongmoi(string str, Player ple)
        {
            Room r = new Room();
            r.sophong = phong.Count+1;
            r.siso = 1;
            r.plnguoichoi1 = ple;
            phong.Add(r);
            ple.room = r;
        }
        private void setnameclient(string str,Player ple)
        {
            a_str = str.Split(',');
            ple.name = a_str[1];
        }
        private void Winner(string str, byte[] data,Player ple)
        {
            a_str = str.Split(',');
            
            SendAClient((int.Parse(a_str[1]) == 2) ? ple.room.plnguoichoi2.socket : ple.room.plnguoichoi1.socket, data);
        }
        private void chatphong(byte[] data, Player ple)
        {
            if (ple.room.siso == 1)
                SendAClient(ple.socket, data);
            else
            {
                SendAClient(ple.room.plnguoichoi1.socket, data);
                SendAClient(ple.room.plnguoichoi2.socket, data);
            }
        }
        private void DanhCaRo(string str,byte[] data,Player ple)
        {
            a_str = str.Split(',');
            SendAClient((int.Parse(a_str[3]) == 2) ? ple.room.plnguoichoi2.socket : ple.room.plnguoichoi1.socket, data);
        }
        private void SendAClient(Socket sk, byte[] data)
        {
            sk.Send(data, data.Length, SocketFlags.None);
        }
        private void SendAllClient(byte[] data)
        {
            foreach (Player pl in player)
            {
                pl.socket.Send(data, data.Length, SocketFlags.None);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Visible = true;
                button3.Visible = false;

                server.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}

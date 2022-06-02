using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Data.SqlClient;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DangNhap
{
    public partial class Lobby : Form
    {
        string nickName;
        private bool notConnected = true;
        Modify modify = new Modify();

        public Lobby()
        {
            InitializeComponent();
        }

        public Lobby(string user) : this()
        {
            nickName = user;
            tbNickName.Text = nickName;
        }

        DataTable table = new DataTable();
        public Lobby(DataTable dataTable) : this()
        {
            table = dataTable;
        }

        TcpClient client;
        public object DeserializeData(byte[] theByteArray)
        {
            MemoryStream ms = new MemoryStream(theByteArray);
            BinaryFormatter bf1 = new BinaryFormatter();
            ms.Position = 0;
            return bf1.Deserialize(ms);
        }

        private void clientThread()
        {
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            client = new TcpClient();
            try
            {
                client.Connect(ipe);
                if (client.Connected)
                {
                    notConnected = false;
                    NetworkStream ns = client.GetStream();
                    while (true)
                    {
                        byte[] bytesReceived = new byte[1];
                        ns.Read(bytesReceived, 0, bytesReceived.Length);
                        string notify = Encoding.ASCII.GetString(bytesReceived);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            CreateRoom taophong = new CreateRoom(nickName);
            taophong.ShowDialog();
        }

        private void btnQuickJoin_Click(object sender, EventArgs e)
        {

        }

        private void btnFindRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (notConnected)
                {
                    CheckForIllegalCrossThreadCalls = false;
                    Thread serverthread = new Thread(new ThreadStart(FindRoomThread));
                    serverthread.Start();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void FindRoomThread()
        {
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            client = new TcpClient();
            try
            {
                client.Connect(ipe);
                if (client.Connected)
                {
                    notConnected = false;
                    NetworkStream ns = client.GetStream();
                    while (true)
                    {
                        string message = "TimPhong" + "," + tbID;
                        byte[] data = Encoding.ASCII.GetBytes(message);
                        ns.Write(data, 0, data.Length);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }       
        private void btnBinhDan_Click(object sender, EventArgs e)
        {
            try
            {
                if (notConnected)
                {
                    CheckForIllegalCrossThreadCalls = false;
                    Thread serverthread = new Thread(new ThreadStart(BinhDanThread));
                    serverthread.Start();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);  }
        }

        private void BinhDanThread()
        {
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            client = new TcpClient();
            try
            {
                client.Connect(ipe);
                if (client.Connected)
                {
                    notConnected = false;
                    NetworkStream ns = client.GetStream();
                    while (true)
                    {
                        string message = "Binhdan" + ":" + "\n";
                        byte[] data = Encoding.ASCII.GetBytes(message);
                        ns.Write(data, 0, data.Length);

                        while (true)
                        {
                            byte[] bytesReceived = new byte[1];
                            ns.Read(bytesReceived, 0, bytesReceived.Length);
                            string notify = Encoding.ASCII.GetString(bytesReceived);
                            if (notify == "e")
                            {
                                IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5656);
                                Socket clSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                                clSock.Connect(ipEnd);
                                byte[] Nhan = new byte[1024 * 5000];
                                clSock.Receive(Nhan, 0, Nhan.Length, 0);
                                DataTable dt = (DataTable)DeserializeData(Nhan);
                                dgvRoomList.DataSource = dt;
                                clSock.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
        
        
    
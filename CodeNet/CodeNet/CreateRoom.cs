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

namespace DangNhap
{
    public partial class CreateRoom : Form
    {
        string nickName;
        string gameMode;
        string password;
        string ttPhong;
        bool send = false;
        bool stop = false;

        public CreateRoom()
        {
            InitializeComponent();
        }

        public CreateRoom(string user) : this()
        {
            nickName = user;
        }

        private bool notConnected = true;
        public bool checkAccount(string ac)//kiem tra mat khau 
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{1,20}$");
        }

        TcpClient client;
        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text != "")
            {
                if (!checkAccount(tbPassword.Text)) { MessageBox.Show("Vui lòng nhập mật khẩu từ 6-20 kí tự gồm chữ hoa , chữ thường và số "); return; }
                else
                {
                    try
                    {
                        if (notConnected)
                        {
                            CheckForIllegalCrossThreadCalls = false;
                            Thread serverthread = new Thread(new ThreadStart(createRoomThread));
                            serverthread.Start();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                try
                {
                    if (notConnected)
                    {
                        CheckForIllegalCrossThreadCalls = false;
                        Thread serverthread = new Thread(new ThreadStart(createRoomThread));
                        serverthread.Start();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void createRoomThread()
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
                        password = tbPassword.Text;
                        string message = "tp" + ":" + nickName + "," + gameMode + "." + password + "\n";
                        byte[] data = Encoding.ASCII.GetBytes(message);
                        ns.Write(data, 0, data.Length);

                        String notify = "";
                        byte[] bytesReceived = new byte[40];
                        ns.Read(bytesReceived, 0, bytesReceived.Length);                                               
                        notify += Encoding.ASCII.GetString(bytesReceived);
                        
                        string[] arr = notify.Split(new char[] { '.' });                      
                        if (arr[0] == "taophong")
                        {                          
                            ttPhong = arr[1];                           
                            ns.Close();
                            this.Close();
                            GameRoom pg = new GameRoom(ttPhong);
                            pg.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        
        /*private void SendMessage()
        {
            send = true;
        }*/

        private void rdbCaoThu_CheckedChanged(object sender, EventArgs e)
        {
            gameMode = "CaoThu";
        }

        private void rdbBinhDan_CheckedChanged(object sender, EventArgs e)
        {
            gameMode = "BinhDan";
        }

        private void rdbKienTuong_CheckedChanged(object sender, EventArgs e)
        {
            gameMode = "KienTuong";
        }

        private void CreateRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (client != null)
            {
                stop = true;
                send = true;
            }
        }
    }
}

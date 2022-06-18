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
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Threading;
namespace Client
{
    public partial class SignUp : Form
    {
        string userName;
        string password;
        string re_password;
        public SignUp()
        {
            InitializeComponent();
        }
        public bool checkAccount(string ac)//kiem tra nickName dang nhap, mat khau 
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,20}$");
        }
        //Modify modify = new Modify();
        private bool notConnected = true;
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            userName = tbUsername.Text;
            password = tbPassword.Text;
            re_password = tbRe_Password.Text;
            if (!checkAccount(userName)) { MessageBox.Show("Vui lòng nhập tên đăng nhập từ 6-20 kí tự gồm chữ hoa , chữ thường và số "); return; }
            if (!checkAccount(password)) { MessageBox.Show("Vui lòng nhập mật khẩu từ 6-20 kí tự gồm chữ hoa , chữ thường và số "); return; }
            if (re_password != password) { MessageBox.Show("Vui lòng xác nhận lại mật khẩu "); return; }
            try
            {
                if (notConnected)
                {
                    CheckForIllegalCrossThreadCalls = false;
                    Thread serverthread = new Thread(new ThreadStart(clientThread));
                    serverthread.Start();
                }
                SendMessage();
            }
            catch { MessageBox.Show("Tên đăng nhập này đã được đăng kí, Vui lòng nhập tên khác !"); }
        }
        TcpClient client;
        private void clientThread()
        {
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9124);
            client = new TcpClient();
            
                client.Connect(ipe);
                if (client.Connected)
                {
                    notConnected = false;
                    NetworkStream ns = client.GetStream();
                    while (true)
                    {
                        if (send)
                        {
                            if (stop)
                            {
                                byte[] msg = Encoding.ASCII.GetBytes("q\n");
                                ns.Write(msg, 0, msg.Length);
                                ns.Close();
                                client.Close();
                                return;
                            }
                            string message = "dkdn" + ":" + userName + "," + password + "." + "dk" + "\n";
                            byte[] data = Encoding.ASCII.GetBytes(message);
                            ns.Write(data, 0, data.Length);
                            send = false;
                        }
                        byte[] bytesReceived = new byte[1];
                        ns.Read(bytesReceived, 0, bytesReceived.Length);
                        string notify = Encoding.ASCII.GetString(bytesReceived);
                        if (notify == "c")
                        {
                            MessageBox.Show("Dang kí tài khoản thành công! Hãy đăng nhập ngay bây giờ !");
                            this.Close();
                        }
                        else if (notify == "d")
                        {
                            MessageBox.Show("Tài khoản đã tồn tại !");
                            this.Close();
                            SignUp dk = new SignUp();
                            dk.ShowDialog();
                        }
                    }
                }
           
        }

        private bool send = false;
        private void SendMessage()
        {
            send = true;
        }

        bool stop = false;

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null)
            {
                stop = true;
                send = true;
            }
        }
    }
}

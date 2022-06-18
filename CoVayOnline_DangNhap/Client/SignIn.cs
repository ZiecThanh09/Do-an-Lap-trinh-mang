using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Threading;
namespace Client
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        string userName;
        string password;
        private bool notConnected = true;
        private bool send = false;
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            userName = tbUsername.Text;
            password = tbPassword.Text;
            if (userName.Trim() == "") { MessageBox.Show("Vui lòng nhập tên đăng nhập "); }
            else if (password.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu "); }
            else
            {
                if (notConnected)
                {
                    CheckForIllegalCrossThreadCalls = false;
                    Thread serverthread = new Thread(new ThreadStart(clientThread));
                    serverthread.Start();
                }
                SendMessage();
            }
        }
        TcpClient client;
        
        private void clientThread()
        {

            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9124);
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
                        string message = "dkdn" + ":" + userName + "," + password + "." + "dn" + "\n";
                        byte[] data = Encoding.ASCII.GetBytes(message);
                        ns.Write(data, 0, data.Length);
                        send = false;
                        byte[] bytesReceived = new byte[1];
                        ns.Read(bytesReceived, 0, bytesReceived.Length);
                        string notify = Encoding.ASCII.GetString(bytesReceived);
                        if (notify == "a")
                        {
                            this.Close();
                            ns.Close();
                            FrmGame frm = new FrmGame();
                            frm.nickName = userName;                               
                            frm.ShowDialog();  
                        }
                        else if (notify == "b")
                        {
                            this.Close();
                            ns.Close();
                            MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                            SignIn signIn = new SignIn();
                            signIn.ShowDialog();
                        }
                    }
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void SendMessage()
        {
            send = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignIn_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (client != null)
            {
                send = true;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }
    }
}

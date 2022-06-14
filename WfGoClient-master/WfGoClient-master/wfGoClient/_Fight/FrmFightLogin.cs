using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfGoClient
{
    public partial class FrmFightLogin : Form
    {
        public FrmFightLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //是否输入检测
            if (TxtUserID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên người dùng！", "gợi ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (TxtPwd.Text == "")
            {
                MessageBox.Show("Vui lòng điền mật khẩu！", "gợi ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //用户名密码合法检测
            if (TxtUserID.Text.Length < 3)
            {
                MessageBox.Show("tên người dùng hoặc mật khẩu sai！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (TxtPwd.Text != "123")
            {
                MessageBox.Show("tên người dùng hoặc mật khẩu sai！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //合法，进入

            //MessageBox.Show("登录成功！", "提示");

            FrmStart.client = new wfGoClient(TxtUserID.Text);
            FrmStart.client.Connect();
            FrmStart.client.SendNameMSG(TxtUserID.Text);
            FrmStart.client.StartListenThread();
            FrmStart.client.StartSendHeartbeatThread();


            FrmStart.main = new FrmFightMain(TxtUserID.Text);
            FrmStart.main.Show();
            this.Close();



        }

        private void FrmFightLogin_Load(object sender, EventArgs e)
        {
            TxtUserID.Text = "wufan";
            TxtPwd.Text = "123";
        }
    }
}

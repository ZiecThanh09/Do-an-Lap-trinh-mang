using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhap
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            SignIn signUp = new SignIn();
            signUp.Show();
       }

        private void btnServer_Click(object sender, EventArgs e)
        {
            Server sv = new Server();
            sv.Show();
        }
    }
}

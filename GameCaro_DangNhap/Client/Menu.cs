using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignIn signin=new SignIn();
            signin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // Form1 server = new Form1();
           // server.Show();
        }
    }
}

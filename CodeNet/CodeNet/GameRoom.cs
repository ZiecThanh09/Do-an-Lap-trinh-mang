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
    public partial class GameRoom : Form
    {
        string NhanttPhong;
        string user;
        string id;

        public GameRoom()
        {
            InitializeComponent();
        }

        public GameRoom(string ttPhong): this()
        {
            NhanttPhong = ttPhong;
            string[] arr = NhanttPhong.Split(new char[] { ',' });
            user=arr[0];
            id=arr[1];
            textBox1.Text = user;
            textBox2.Text = id;
        }
    }
}

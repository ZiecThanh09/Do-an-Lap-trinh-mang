using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace wfGoClient
{
    public partial class FrmFightMain : Form
    {
        FightPlayer player;

        public FrmFightMain(string name)
        {
            InitializeComponent();

            player = new FightPlayer(name);
        }

        private void FrmFightMain_Load(object sender, EventArgs e)
        {
            labelUserID.Text = player.name;
            LblInfo.Text = "";
            FrmStart.client.frmfightmain = this;
        }

        private void BtnCreatRoom_Click(object sender, EventArgs e)
        {
            //Gửi yêu cầu tạo phòng
            FrmStart.client.SendCreatRoomMSG(player.name+ "phòng của ~");
        }

        private void BtnComeInRoom_Click(object sender, EventArgs e)
        {
            if(FrmStart.client.player.roomnumber!=0)
            {
                MessageBox.Show("Vui lòng ra khỏi phòng trước！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(ListView1.SelectedItems.Count==0)
            {
                MessageBox.Show("Vui lòng chọn phòng！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Gửi yêu cầu vào phòng
            string roomnumber = ListView1.SelectedItems[0].SubItems[0].Text;
            int roomnb = Convert.ToInt32(roomnumber);
            FrmStart.client.SendComeInRoomMSG(roomnb);

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

namespace Client
{
    partial class FrmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlgame = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbidphong = new System.Windows.Forms.Label();
            this.rtbchat = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbcontentchat = new System.Windows.Forms.RichTextBox();
            this.plroom = new System.Windows.Forms.Panel();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ltbdanhsachphonggame = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btntaophongmoi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlgame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plroom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlgame
            // 
            this.pnlgame.BackgroundImage = global::Client.Properties.Resources.bgcaro;
            this.pnlgame.Controls.Add(this.pictureBox3);
            this.pnlgame.Controls.Add(this.lbidphong);
            this.pnlgame.Controls.Add(this.rtbchat);
            this.pnlgame.Controls.Add(this.pictureBox2);
            this.pnlgame.Controls.Add(this.pictureBox1);
            this.pnlgame.Controls.Add(this.panel1);
            this.pnlgame.Controls.Add(this.rtbcontentchat);
            this.pnlgame.Location = new System.Drawing.Point(0, 0);
            this.pnlgame.Name = "pnlgame";
            this.pnlgame.Size = new System.Drawing.Size(802, 545);
            this.pnlgame.TabIndex = 9;
            this.pnlgame.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Client.Properties.Resources.thoa;
            this.pictureBox3.Location = new System.Drawing.Point(734, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 51);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lbidphong
            // 
            this.lbidphong.AutoSize = true;
            this.lbidphong.BackColor = System.Drawing.Color.Transparent;
            this.lbidphong.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbidphong.ForeColor = System.Drawing.Color.White;
            this.lbidphong.Location = new System.Drawing.Point(301, 32);
            this.lbidphong.Name = "lbidphong";
            this.lbidphong.Size = new System.Drawing.Size(33, 31);
            this.lbidphong.TabIndex = 9;
            this.lbidphong.Text = "0";
            // 
            // rtbchat
            // 
            this.rtbchat.BackColor = System.Drawing.Color.LightCyan;
            this.rtbchat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbchat.Location = new System.Drawing.Point(635, 516);
            this.rtbchat.Name = "rtbchat";
            this.rtbchat.Size = new System.Drawing.Size(165, 28);
            this.rtbchat.TabIndex = 7;
            this.rtbchat.Text = "";
            this.rtbchat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbchat_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Client.Properties.Resources.bgchat;
            this.pictureBox2.Location = new System.Drawing.Point(679, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 49);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Client.Properties.Resources.bgchat;
            this.pictureBox1.Location = new System.Drawing.Point(44, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(186, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 401);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // rtbcontentchat
            // 
            this.rtbcontentchat.BackColor = System.Drawing.Color.LightCyan;
            this.rtbcontentchat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbcontentchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbcontentchat.Location = new System.Drawing.Point(634, 390);
            this.rtbcontentchat.Name = "rtbcontentchat";
            this.rtbcontentchat.Size = new System.Drawing.Size(166, 123);
            this.rtbcontentchat.TabIndex = 6;
            this.rtbcontentchat.Text = "";
            // 
            // plroom
            // 
            this.plroom.Controls.Add(this.label3);
            this.plroom.Controls.Add(this.richTextBox3);
            this.plroom.Controls.Add(this.label2);
            this.plroom.Controls.Add(this.button3);
            this.plroom.Controls.Add(this.richTextBox2);
            this.plroom.Controls.Add(this.richTextBox1);
            this.plroom.Controls.Add(this.button1);
            this.plroom.Controls.Add(this.label1);
            this.plroom.Controls.Add(this.ltbdanhsachphonggame);
            this.plroom.Controls.Add(this.button2);
            this.plroom.Controls.Add(this.btntaophongmoi);
            this.plroom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plroom.Location = new System.Drawing.Point(0, 0);
            this.plroom.Name = "plroom";
            this.plroom.Size = new System.Drawing.Size(802, 545);
            this.plroom.TabIndex = 10;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(608, 263);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(191, 183);
            this.richTextBox3.TabIndex = 12;
            this.richTextBox3.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "CHAT";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(130, 451);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 45);
            this.button3.TabIndex = 10;
            this.button3.Text = "Gửi";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(3, 451);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(121, 45);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(188, 394);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tìm Phòng";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(265, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "DANH SÁCH PHÒNG";
            // 
            // ltbdanhsachphonggame
            // 
            this.ltbdanhsachphonggame.FormattingEnabled = true;
            this.ltbdanhsachphonggame.Location = new System.Drawing.Point(269, 52);
            this.ltbdanhsachphonggame.Name = "ltbdanhsachphonggame";
            this.ltbdanhsachphonggame.Size = new System.Drawing.Size(272, 394);
            this.ltbdanhsachphonggame.TabIndex = 5;
            this.ltbdanhsachphonggame.SelectedIndexChanged += new System.EventHandler(this.ltbdanhsachphonggame_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(715, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btntaophongmoi
            // 
            this.btntaophongmoi.Location = new System.Drawing.Point(216, 452);
            this.btntaophongmoi.Name = "btntaophongmoi";
            this.btntaophongmoi.Size = new System.Drawing.Size(162, 44);
            this.btntaophongmoi.TabIndex = 0;
            this.btntaophongmoi.Text = "Tạo Phòng Mới";
            this.btntaophongmoi.UseVisualStyleBackColor = true;
            this.btntaophongmoi.Click += new System.EventHandler(this.btntaophongmoi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(604, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "THÀNH VIÊN ONNLINE";
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 545);
            this.Controls.Add(this.plroom);
            this.Controls.Add(this.pnlgame);
            this.Name = "FrmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.pnlgame.ResumeLayout(false);
            this.pnlgame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plroom.ResumeLayout(false);
            this.plroom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox rtbcontentchat;
        private System.Windows.Forms.RichTextBox rtbchat;
        private System.Windows.Forms.Panel pnlgame;
        private System.Windows.Forms.Label lbidphong;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel plroom;
        private System.Windows.Forms.Button btntaophongmoi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox ltbdanhsachphonggame;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
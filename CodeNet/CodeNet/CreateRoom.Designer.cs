namespace DangNhap
{
    partial class CreateRoom
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
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbKienTuong = new System.Windows.Forms.RadioButton();
            this.rdbCaoThu = new System.Windows.Forms.RadioButton();
            this.rdbBinhDan = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Location = new System.Drawing.Point(142, 192);
            this.btnCreateRoom.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(66, 45);
            this.btnCreateRoom.TabIndex = 2;
            this.btnCreateRoom.Text = "Tạo Phòng";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật Khẩu:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(92, 158);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(116, 20);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbKienTuong);
            this.groupBox1.Controls.Add(this.rdbCaoThu);
            this.groupBox1.Controls.Add(this.rdbBinhDan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(185, 119);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Cấp Độ:";
            // 
            // rdbKienTuong
            // 
            this.rdbKienTuong.AutoSize = true;
            this.rdbKienTuong.Location = new System.Drawing.Point(14, 74);
            this.rdbKienTuong.Margin = new System.Windows.Forms.Padding(2);
            this.rdbKienTuong.Name = "rdbKienTuong";
            this.rdbKienTuong.Size = new System.Drawing.Size(101, 22);
            this.rdbKienTuong.TabIndex = 1;
            this.rdbKienTuong.TabStop = true;
            this.rdbKienTuong.Text = "TướngKiện ";
            this.rdbKienTuong.UseVisualStyleBackColor = true;
            this.rdbKienTuong.CheckedChanged += new System.EventHandler(this.rdbKienTuong_CheckedChanged);
            // 
            // rdbCaoThu
            // 
            this.rdbCaoThu.AutoSize = true;
            this.rdbCaoThu.Location = new System.Drawing.Point(14, 48);
            this.rdbCaoThu.Margin = new System.Windows.Forms.Padding(2);
            this.rdbCaoThu.Name = "rdbCaoThu";
            this.rdbCaoThu.Size = new System.Drawing.Size(83, 22);
            this.rdbCaoThu.TabIndex = 0;
            this.rdbCaoThu.TabStop = true;
            this.rdbCaoThu.Text = "Cao Thủ";
            this.rdbCaoThu.UseVisualStyleBackColor = true;
            this.rdbCaoThu.CheckedChanged += new System.EventHandler(this.rdbCaoThu_CheckedChanged);
            // 
            // rdbBinhDan
            // 
            this.rdbBinhDan.AutoSize = true;
            this.rdbBinhDan.Location = new System.Drawing.Point(14, 22);
            this.rdbBinhDan.Margin = new System.Windows.Forms.Padding(2);
            this.rdbBinhDan.Name = "rdbBinhDan";
            this.rdbBinhDan.Size = new System.Drawing.Size(86, 22);
            this.rdbBinhDan.TabIndex = 0;
            this.rdbBinhDan.TabStop = true;
            this.rdbBinhDan.Text = "Bình Dân";
            this.rdbBinhDan.UseVisualStyleBackColor = true;
            this.rdbBinhDan.CheckedChanged += new System.EventHandler(this.rdbBinhDan_CheckedChanged);
            // 
            // CreateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 307);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreateRoom);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateRoom";
            this.Text = "Create Room";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateRoom_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreateRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbKienTuong;
        private System.Windows.Forms.RadioButton rdbCaoThu;
        private System.Windows.Forms.RadioButton rdbBinhDan;
    }
}
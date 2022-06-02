namespace DangNhap
{
    partial class Lobby
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
            this.btnFindRoom = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnBinhDan = new System.Windows.Forms.Button();
            this.btnCaoThu = new System.Windows.Forms.Button();
            this.btnKienTuong = new System.Windows.Forms.Button();
            this.btnQuickJoin = new System.Windows.Forms.Button();
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.tbNickName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRoomList = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFindRoom
            // 
            this.btnFindRoom.Location = new System.Drawing.Point(764, 221);
            this.btnFindRoom.Margin = new System.Windows.Forms.Padding(2);
            this.btnFindRoom.Name = "btnFindRoom";
            this.btnFindRoom.Size = new System.Drawing.Size(110, 36);
            this.btnFindRoom.TabIndex = 1;
            this.btnFindRoom.Text = "Tìm Phòng";
            this.btnFindRoom.UseVisualStyleBackColor = true;
            this.btnFindRoom.Click += new System.EventHandler(this.btnFindRoom_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(764, 198);
            this.tbID.Margin = new System.Windows.Forms.Padding(2);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(101, 20);
            this.tbID.TabIndex = 2;
            this.tbID.Text = "Nhập id phòng ...";
            // 
            // btnBinhDan
            // 
            this.btnBinhDan.Location = new System.Drawing.Point(391, 124);
            this.btnBinhDan.Margin = new System.Windows.Forms.Padding(2);
            this.btnBinhDan.Name = "btnBinhDan";
            this.btnBinhDan.Size = new System.Drawing.Size(72, 60);
            this.btnBinhDan.TabIndex = 3;
            this.btnBinhDan.Text = "Bình Dân";
            this.btnBinhDan.UseVisualStyleBackColor = true;
            this.btnBinhDan.Click += new System.EventHandler(this.btnBinhDan_Click);
            // 
            // btnCaoThu
            // 
            this.btnCaoThu.Location = new System.Drawing.Point(500, 124);
            this.btnCaoThu.Margin = new System.Windows.Forms.Padding(2);
            this.btnCaoThu.Name = "btnCaoThu";
            this.btnCaoThu.Size = new System.Drawing.Size(74, 60);
            this.btnCaoThu.TabIndex = 3;
            this.btnCaoThu.Text = "Cao Thủ";
            this.btnCaoThu.UseVisualStyleBackColor = true;
            // 
            // btnKienTuong
            // 
            this.btnKienTuong.Location = new System.Drawing.Point(604, 124);
            this.btnKienTuong.Margin = new System.Windows.Forms.Padding(2);
            this.btnKienTuong.Name = "btnKienTuong";
            this.btnKienTuong.Size = new System.Drawing.Size(95, 59);
            this.btnKienTuong.TabIndex = 3;
            this.btnKienTuong.Text = "Kiện Tướng";
            this.btnKienTuong.UseVisualStyleBackColor = true;
            // 
            // btnQuickJoin
            // 
            this.btnQuickJoin.Location = new System.Drawing.Point(764, 318);
            this.btnQuickJoin.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuickJoin.Name = "btnQuickJoin";
            this.btnQuickJoin.Size = new System.Drawing.Size(99, 44);
            this.btnQuickJoin.TabIndex = 4;
            this.btnQuickJoin.Text = "Vào Nhanh";
            this.btnQuickJoin.UseVisualStyleBackColor = true;
            this.btnQuickJoin.Click += new System.EventHandler(this.btnQuickJoin_Click);
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Location = new System.Drawing.Point(18, 198);
            this.btnCreateRoom.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(56, 81);
            this.btnCreateRoom.TabIndex = 5;
            this.btnCreateRoom.Text = "Tạo Phòng";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // tbNickName
            // 
            this.tbNickName.Enabled = false;
            this.tbNickName.Location = new System.Drawing.Point(728, 27);
            this.tbNickName.Margin = new System.Windows.Forms.Padding(2);
            this.tbNickName.Name = "tbNickName";
            this.tbNickName.ReadOnly = true;
            this.tbNickName.Size = new System.Drawing.Size(218, 20);
            this.tbNickName.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRoomList);
            this.groupBox1.Location = new System.Drawing.Point(165, 198);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(580, 164);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách phòng : ";
            // 
            // dgvRoomList
            // 
            this.dgvRoomList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomList.Location = new System.Drawing.Point(4, 0);
            this.dgvRoomList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRoomList.Name = "dgvRoomList";
            this.dgvRoomList.RowHeadersWidth = 51;
            this.dgvRoomList.RowTemplate.Height = 24;
            this.dgvRoomList.Size = new System.Drawing.Size(571, 159);
            this.dgvRoomList.TabIndex = 0;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 535);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbNickName);
            this.Controls.Add(this.btnCreateRoom);
            this.Controls.Add(this.btnQuickJoin);
            this.Controls.Add(this.btnKienTuong);
            this.Controls.Add(this.btnCaoThu);
            this.Controls.Add(this.btnBinhDan);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btnFindRoom);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Lobby";
            this.Text = "Lobby";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindRoom;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnBinhDan;
        private System.Windows.Forms.Button btnCaoThu;
        private System.Windows.Forms.Button btnKienTuong;
        private System.Windows.Forms.Button btnQuickJoin;
        private System.Windows.Forms.Button btnCreateRoom;
        private System.Windows.Forms.TextBox tbNickName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRoomList;
    }
}
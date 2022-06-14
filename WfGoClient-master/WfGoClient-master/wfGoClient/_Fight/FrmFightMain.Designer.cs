﻿namespace wfGoClient
{
    public partial class FrmFightMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblOnLineNum = new System.Windows.Forms.Label();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnCreatRoom = new System.Windows.Forms.Button();
            this.BtnComeInRoom = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin chào";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUserID.Location = new System.Drawing.Point(166, 12);
            this.labelUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(235, 34);
            this.labelUserID.TabIndex = 1;
            this.labelUserID.Text = "tên tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Người dùng trực tuyến:";
            // 
            // LblOnLineNum
            // 
            this.LblOnLineNum.AutoSize = true;
            this.LblOnLineNum.Location = new System.Drawing.Point(716, 32);
            this.LblOnLineNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblOnLineNum.Name = "LblOnLineNum";
            this.LblOnLineNum.Size = new System.Drawing.Size(77, 16);
            this.LblOnLineNum.TabIndex = 3;
            this.LblOnLineNum.Text = "OnLineNum";
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ListView1.FullRowSelect = true;
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(23, 76);
            this.ListView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListView1.MultiSelect = false;
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(772, 532);
            this.ListView1.TabIndex = 4;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "房间号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "房间名";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 395;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "状态";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "人数";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnCreatRoom
            // 
            this.BtnCreatRoom.Location = new System.Drawing.Point(476, 637);
            this.BtnCreatRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCreatRoom.Name = "BtnCreatRoom";
            this.BtnCreatRoom.Size = new System.Drawing.Size(123, 63);
            this.BtnCreatRoom.TabIndex = 5;
            this.BtnCreatRoom.Text = "创建房间";
            this.BtnCreatRoom.UseVisualStyleBackColor = true;
            this.BtnCreatRoom.Click += new System.EventHandler(this.BtnCreatRoom_Click);
            // 
            // BtnComeInRoom
            // 
            this.BtnComeInRoom.Location = new System.Drawing.Point(672, 637);
            this.BtnComeInRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnComeInRoom.Name = "BtnComeInRoom";
            this.BtnComeInRoom.Size = new System.Drawing.Size(123, 63);
            this.BtnComeInRoom.TabIndex = 6;
            this.BtnComeInRoom.Text = "进入房间";
            this.BtnComeInRoom.UseVisualStyleBackColor = true;
            this.BtnComeInRoom.Click += new System.EventHandler(this.BtnComeInRoom_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 637);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "公告：";
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Location = new System.Drawing.Point(96, 637);
            this.LblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(46, 16);
            this.LblInfo.TabIndex = 8;
            this.LblInfo.Text = "LblInfo";
            // 
            // FrmFightMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 748);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnComeInRoom);
            this.Controls.Add(this.BtnCreatRoom);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.LblOnLineNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmFightMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wfGoClient-联机模式大厅";
            this.Load += new System.EventHandler(this.FrmFightMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button BtnCreatRoom;
        private System.Windows.Forms.Button BtnComeInRoom;
        private System.Windows.Forms.Label label3;


        public System.Windows.Forms.Label LblInfo;
        public System.Windows.Forms.Label LblOnLineNum;
        public System.Windows.Forms.ListView ListView1;
        


    }
}
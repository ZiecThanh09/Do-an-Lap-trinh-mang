namespace GoViewer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.itemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.statPanel = new System.Windows.Forms.Panel();
            this.lbltime = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.btnJudge = new System.Windows.Forms.Button();
            this.btnMode = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timerView = new System.Windows.Forms.Timer(this.components);
            this.menu.SuspendLayout();
            this.statPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menu.Size = new System.Drawing.Size(1218, 32);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemOpen,
            this.itemSave,
            this.itemSaveAs,
            this.itemQuit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(65, 24);
            this.menuFile.Text = "MENU";
            // 
            // itemOpen
            // 
            this.itemOpen.Name = "itemOpen";
            this.itemOpen.Size = new System.Drawing.Size(194, 26);
            this.itemOpen.Text = "Mở sách cờ vua";
            this.itemOpen.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // itemSave
            // 
            this.itemSave.Name = "itemSave";
            this.itemSave.Size = new System.Drawing.Size(194, 26);
            this.itemSave.Text = "Trợ giúp";
            // 
            // itemSaveAs
            // 
            this.itemSaveAs.Name = "itemSaveAs";
            this.itemSaveAs.Size = new System.Drawing.Size(194, 26);
            this.itemSaveAs.Text = "Lưu";
            // 
            // itemQuit
            // 
            this.itemQuit.Name = "itemQuit";
            this.itemQuit.Size = new System.Drawing.Size(194, 26);
            this.itemQuit.Text = "Từ bỏ";
            this.itemQuit.Click += new System.EventHandler(this.itemQuit_Click);
            // 
            // statPanel
            // 
            this.statPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.statPanel.Controls.Add(this.lbltime);
            this.statPanel.Controls.Add(this.lblResult);
            this.statPanel.Controls.Add(this.label1);
            this.statPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.statPanel.Location = new System.Drawing.Point(990, 32);
            this.statPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.statPanel.Name = "statPanel";
            this.statPanel.Size = new System.Drawing.Size(228, 702);
            this.statPanel.TabIndex = 1;
            this.statPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.statPanel_Paint);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(22, 30);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(0, 25);
            this.lbltime.TabIndex = 3;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.ForeColor = System.Drawing.Color.DarkRed;
            this.lblResult.Location = new System.Drawing.Point(23, 372);
            this.lblResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(76, 26);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "label3";
            this.lblResult.Visible = false;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 0;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.controlPanel.Controls.Add(this.btnJudge);
            this.controlPanel.Controls.Add(this.btnMode);
            this.controlPanel.Controls.Add(this.btnEnd);
            this.controlPanel.Controls.Add(this.btnNext);
            this.controlPanel.Controls.Add(this.btnPrevious);
            this.controlPanel.Controls.Add(this.btnStart);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 620);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(990, 114);
            this.controlPanel.TabIndex = 2;
            // 
            // btnJudge
            // 
            this.btnJudge.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnJudge.Location = new System.Drawing.Point(605, 29);
            this.btnJudge.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnJudge.Name = "btnJudge";
            this.btnJudge.Size = new System.Drawing.Size(101, 30);
            this.btnJudge.TabIndex = 6;
            this.btnJudge.Text = "Điểm";
            this.btnJudge.UseVisualStyleBackColor = true;
            this.btnJudge.Click += new System.EventHandler(this.btnJudge_Click);
            // 
            // btnMode
            // 
            this.btnMode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMode.Location = new System.Drawing.Point(759, 29);
            this.btnMode.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(132, 30);
            this.btnMode.TabIndex = 4;
            this.btnMode.Text = "Điểm tự động";
            this.btnMode.UseVisualStyleBackColor = true;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEnd.Location = new System.Drawing.Point(445, 29);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(101, 30);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "Hoàn thành";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.Location = new System.Drawing.Point(289, 29);
            this.btnNext.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(101, 30);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Bước tiếp theo";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrevious.Location = new System.Drawing.Point(135, 29);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(101, 30);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Trước";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.Location = new System.Drawing.Point(-12, 29);
            this.btnStart.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 30);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timerView
            // 
            this.timerView.Interval = 1000;
            this.timerView.Tick += new System.EventHandler(this.timerView_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 734);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.statPanel);
            this.Controls.Add(this.menu);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(48, 59);
            this.Name = "MainForm";
            this.Text = "Cờ vây";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.statPanel.ResumeLayout(false);
            this.statPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem itemOpen;
        private System.Windows.Forms.ToolStripMenuItem itemSave;
        private System.Windows.Forms.ToolStripMenuItem itemSaveAs;
        private System.Windows.Forms.ToolStripMenuItem itemQuit;
        private System.Windows.Forms.Panel statPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Timer timerView;
        private System.Windows.Forms.Button btnJudge;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lbltime;
    }
}


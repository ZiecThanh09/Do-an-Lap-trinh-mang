namespace wfGoClient
{
    public partial class FrmStart
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSingleModul = new System.Windows.Forms.Button();
            this.BtnFightModul = new System.Windows.Forms.Button();
            this.BtnAIModul = new System.Windows.Forms.Button();
            this.BtnQiPu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSingleModul
            // 
            this.BtnSingleModul.Location = new System.Drawing.Point(68, 73);
            this.BtnSingleModul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSingleModul.Name = "BtnSingleModul";
            this.BtnSingleModul.Size = new System.Drawing.Size(224, 77);
            this.BtnSingleModul.TabIndex = 0;
            this.BtnSingleModul.Text = "Chơi 1 VS 1";
            this.BtnSingleModul.UseVisualStyleBackColor = true;
            this.BtnSingleModul.Click += new System.EventHandler(this.BtnSingleModul_Click);
            // 
            // BtnFightModul
            // 
            this.BtnFightModul.Location = new System.Drawing.Point(68, 195);
            this.BtnFightModul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnFightModul.Name = "BtnFightModul";
            this.BtnFightModul.Size = new System.Drawing.Size(224, 77);
            this.BtnFightModul.TabIndex = 1;
            this.BtnFightModul.Text = "Chơi trực tuyến";
            this.BtnFightModul.UseVisualStyleBackColor = true;
            this.BtnFightModul.Click += new System.EventHandler(this.BtnFightModul_Click);
            // 
            // BtnAIModul
            // 
            this.BtnAIModul.Location = new System.Drawing.Point(68, 319);
            this.BtnAIModul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAIModul.Name = "BtnAIModul";
            this.BtnAIModul.Size = new System.Drawing.Size(224, 77);
            this.BtnAIModul.TabIndex = 2;
            this.BtnAIModul.Text = "Chơi với máy";
            this.BtnAIModul.UseVisualStyleBackColor = true;
            this.BtnAIModul.Click += new System.EventHandler(this.BtnAIModul_Click);
            // 
            // BtnQiPu
            // 
            this.BtnQiPu.Location = new System.Drawing.Point(361, 73);
            this.BtnQiPu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnQiPu.Name = "BtnQiPu";
            this.BtnQiPu.Size = new System.Drawing.Size(224, 77);
            this.BtnQiPu.TabIndex = 3;
            this.BtnQiPu.Text = "Cách chơi";
            this.BtnQiPu.UseVisualStyleBackColor = true;
            this.BtnQiPu.Click += new System.EventHandler(this.BtnQiPu_Click);
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 535);
            this.Controls.Add(this.BtnQiPu);
            this.Controls.Add(this.BtnAIModul);
            this.Controls.Add(this.BtnFightModul);
            this.Controls.Add(this.BtnSingleModul);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wfGoClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStart_FormClosing);
            this.Load += new System.EventHandler(this.FrmStart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSingleModul;
        private System.Windows.Forms.Button BtnFightModul;
        private System.Windows.Forms.Button BtnAIModul;
        private System.Windows.Forms.Button BtnQiPu;
    }
}


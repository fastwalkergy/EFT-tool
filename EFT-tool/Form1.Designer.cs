namespace EFT_tool
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.addreg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addreg
            // 
            this.addreg.Location = new System.Drawing.Point(57, 54);
            this.addreg.Name = "addreg";
            this.addreg.Size = new System.Drawing.Size(113, 56);
            this.addreg.TabIndex = 0;
            this.addreg.Text = "增加注册表";
            this.addreg.UseVisualStyleBackColor = true;
            this.addreg.Click += new System.EventHandler(this.addreg_Click);
            // 
            // main
            // 
            this.BackgroundImage = global::EFT_tool.Properties.Resources.tkf_l3r5vq_1280x720;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 396);
            this.Controls.Add(this.addreg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "EFT-tool";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addreg;
    }
}


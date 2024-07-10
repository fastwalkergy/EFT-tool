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
            this.setting = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.Label();
            this.delgenuinebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addreg
            // 
            resources.ApplyResources(this.addreg, "addreg");
            this.addreg.Name = "addreg";
            this.addreg.UseVisualStyleBackColor = true;
            this.addreg.Click += new System.EventHandler(this.addreg_Click);
            // 
            // setting
            // 
            resources.ApplyResources(this.setting, "setting");
            this.setting.Name = "setting";
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // version
            // 
            resources.ApplyResources(this.version, "version");
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.version.Name = "version";
            // 
            // delgenuinebutton
            // 
            resources.ApplyResources(this.delgenuinebutton, "delgenuinebutton");
            this.delgenuinebutton.Name = "delgenuinebutton";
            this.delgenuinebutton.UseVisualStyleBackColor = true;
            this.delgenuinebutton.Click += new System.EventHandler(this.delgenuinebutton_Click);
            // 
            // main
            // 
            this.BackgroundImage = global::EFT_tool.Properties.Resources.tkf_l3r5vq_1280x720;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.delgenuinebutton);
            this.Controls.Add(this.version);
            this.Controls.Add(this.setting);
            this.Controls.Add(this.addreg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addreg;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Button delgenuinebutton;
    }
}


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
            this.version = new System.Windows.Forms.Label();
            this.addreg = new AntdUI.Button();
            this.delgenuinebutton = new AntdUI.Button();
            this.settingbutton = new AntdUI.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // version
            // 
            resources.ApplyResources(this.version, "version");
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.version.Name = "version";
            // 
            // addreg
            // 
            this.addreg.BorderWidth = 1F;
            this.addreg.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.addreg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(96)))));
            this.addreg.Ghost = true;
            resources.ApplyResources(this.addreg, "addreg");
            this.addreg.Name = "addreg";
            this.addreg.Radius = 2;
            this.addreg.Click += new System.EventHandler(this.addreg_Click_1);
            // 
            // delgenuinebutton
            // 
            this.delgenuinebutton.BorderWidth = 1F;
            this.delgenuinebutton.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.delgenuinebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(0)))), ((int)(((byte)(41)))));
            this.delgenuinebutton.Ghost = true;
            resources.ApplyResources(this.delgenuinebutton, "delgenuinebutton");
            this.delgenuinebutton.Name = "delgenuinebutton";
            this.delgenuinebutton.Radius = 2;
            this.delgenuinebutton.Click += new System.EventHandler(this.delgenuinebutton_Click_1);
            // 
            // settingbutton
            // 
            this.settingbutton.BorderWidth = 1F;
            this.settingbutton.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.settingbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(96)))));
            this.settingbutton.Ghost = true;
            resources.ApplyResources(this.settingbutton, "settingbutton");
            this.settingbutton.Name = "settingbutton";
            this.settingbutton.Radius = 2;
            this.settingbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Name = "label1";
            // 
            // main
            // 
            this.BackgroundImage = global::EFT_tool.Properties.Resources.tkf_l3r5vq_1280x720;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settingbutton);
            this.Controls.Add(this.delgenuinebutton);
            this.Controls.Add(this.addreg);
            this.Controls.Add(this.version);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label version;
        private AntdUI.Button addreg;
        private AntdUI.Button delgenuinebutton;
        private AntdUI.Button settingbutton;
        private System.Windows.Forms.Label label1;
    }
}


namespace EFT_tool
{
    partial class genuine
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
            this.input1 = new AntdUI.Input();
            this.startdelgenuinebutton = new AntdUI.Button();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.AutoScroll = true;
            this.input1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.input1.BorderActive = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.input1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(200)))), ((int)(((byte)(241)))));
            this.input1.Location = new System.Drawing.Point(14, 39);
            this.input1.Multiline = true;
            this.input1.Name = "input1";
            this.input1.ReadOnly = true;
            this.input1.Size = new System.Drawing.Size(298, 276);
            this.input1.TabIndex = 6;
            // 
            // startdelgenuinebutton
            // 
            this.startdelgenuinebutton.BorderWidth = 1F;
            this.startdelgenuinebutton.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startdelgenuinebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.startdelgenuinebutton.Ghost = true;
            this.startdelgenuinebutton.Location = new System.Drawing.Point(103, 1);
            this.startdelgenuinebutton.Name = "startdelgenuinebutton";
            this.startdelgenuinebutton.Radius = 2;
            this.startdelgenuinebutton.Size = new System.Drawing.Size(119, 32);
            this.startdelgenuinebutton.TabIndex = 7;
            this.startdelgenuinebutton.Text = "开始过正版验证";
            this.startdelgenuinebutton.Click += new System.EventHandler(this.startdelgenuinebutton_Click);
            // 
            // genuine
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(324, 346);
            this.Controls.Add(this.startdelgenuinebutton);
            this.Controls.Add(this.input1);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "genuine";
            this.Text = "过正版验证";
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.Input input1;
        private AntdUI.Button startdelgenuinebutton;
    }
}
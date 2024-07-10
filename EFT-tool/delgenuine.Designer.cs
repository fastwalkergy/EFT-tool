namespace EFT_tool
{
    partial class delgenuine
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
            this.delgenuinebutton = new AntdUI.Button();
            this.input1 = new AntdUI.Input();
            this.label1 = new AntdUI.Label();
            this.SuspendLayout();
            // 
            // delgenuinebutton
            // 
            this.delgenuinebutton.BorderWidth = 1F;
            this.delgenuinebutton.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delgenuinebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.delgenuinebutton.Ghost = true;
            this.delgenuinebutton.Location = new System.Drawing.Point(119, 3);
            this.delgenuinebutton.Name = "delgenuinebutton";
            this.delgenuinebutton.Radius = 2;
            this.delgenuinebutton.Size = new System.Drawing.Size(91, 32);
            this.delgenuinebutton.TabIndex = 4;
            this.delgenuinebutton.Text = "删除正版验证";
            this.delgenuinebutton.Click += new System.EventHandler(this.delgenuinebutton_Click);
            // 
            // input1
            // 
            this.input1.AutoScroll = true;
            this.input1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.input1.BorderActive = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.input1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(200)))), ((int)(((byte)(241)))));
            this.input1.Location = new System.Drawing.Point(14, 41);
            this.input1.Multiline = true;
            this.input1.Name = "input1";
            this.input1.ReadOnly = true;
            this.input1.Size = new System.Drawing.Size(298, 276);
            this.input1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(14, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "如果你知道自己在做什么再使用本功能！！";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // delgenuine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(324, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.delgenuinebutton);
            this.MaximizeBox = false;
            this.Name = "delgenuine";
            this.Text = "删除正版验证";
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.Button delgenuinebutton;
        private AntdUI.Input input1;
        private AntdUI.Label label1;
    }
}
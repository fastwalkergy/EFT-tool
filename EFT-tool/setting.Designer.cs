namespace EFT_tool
{
    partial class setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setting));
            this.pathbutton = new System.Windows.Forms.Button();
            this.pathtxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pathbutton
            // 
            this.pathbutton.Location = new System.Drawing.Point(12, 4);
            this.pathbutton.Name = "pathbutton";
            this.pathbutton.Size = new System.Drawing.Size(75, 23);
            this.pathbutton.TabIndex = 0;
            this.pathbutton.Text = "设置路径";
            this.pathbutton.UseVisualStyleBackColor = true;
            this.pathbutton.Click += new System.EventHandler(this.pathbutton_Click);
            // 
            // pathtxt
            // 
            this.pathtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pathtxt.Location = new System.Drawing.Point(10, 30);
            this.pathtxt.Name = "pathtxt";
            this.pathtxt.Size = new System.Drawing.Size(373, 147);
            this.pathtxt.TabIndex = 1;
            this.pathtxt.Text = "当前路径：未设置";
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 247);
            this.Controls.Add(this.pathtxt);
            this.Controls.Add(this.pathbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "setting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pathbutton;
        private System.Windows.Forms.Label pathtxt;
    }
}
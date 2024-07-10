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
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.startgenuinebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(12, 41);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(300, 324);
            this.textBoxOutput.TabIndex = 0;
            // 
            // startgenuinebutton
            // 
            this.startgenuinebutton.Location = new System.Drawing.Point(129, 12);
            this.startgenuinebutton.Name = "startgenuinebutton";
            this.startgenuinebutton.Size = new System.Drawing.Size(75, 23);
            this.startgenuinebutton.TabIndex = 1;
            this.startgenuinebutton.Text = "开始过验证";
            this.startgenuinebutton.UseVisualStyleBackColor = true;
            this.startgenuinebutton.Click += new System.EventHandler(this.startgenuine_Click);
            // 
            // genuine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 377);
            this.Controls.Add(this.startgenuinebutton);
            this.Controls.Add(this.textBoxOutput);
            this.MaximizeBox = false;
            this.Name = "genuine";
            this.Text = "过正版验证";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button startgenuinebutton;
    }
}
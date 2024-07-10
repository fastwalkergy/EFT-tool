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
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // delgenuinebutton
            // 
            this.delgenuinebutton.Location = new System.Drawing.Point(119, 3);
            this.delgenuinebutton.Name = "delgenuinebutton";
            this.delgenuinebutton.Size = new System.Drawing.Size(91, 32);
            this.delgenuinebutton.TabIndex = 4;
            this.delgenuinebutton.Text = "删除正版验证";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(12, 41);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(300, 324);
            this.textBoxOutput.TabIndex = 3;
            // 
            // delgenuine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 377);
            this.Controls.Add(this.delgenuinebutton);
            this.Controls.Add(this.textBoxOutput);
            this.MaximizeBox = false;
            this.Name = "delgenuine";
            this.Text = "delgenuine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AntdUI.Button delgenuinebutton;
        private System.Windows.Forms.TextBox textBoxOutput;
    }
}
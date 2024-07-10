using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EFT_tool
{
    public partial class main : Form
    {
        
       // string keyName = "SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\EscapeFromTarkov";
        public main()
        {
            InitializeComponent();
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            this.version.Text = $"Version: {version}";
        }

        private void addreg_Click(object sender, EventArgs e)
        {
            genuine genuine = new genuine();
            genuine.ShowDialog();
            /*
            try
            {
                // 创建或打开注册表项
                using (RegistryKey key = Registry.LocalMachine.CreateSubKey(keyName))
                {
                    // 添加一个名为 "Version" 的字符串值
                    key.SetValue("Version", "1.0");
                    MessageBox.Show("注册表增加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void setting_Click(object sender, EventArgs e)
        {
            setting setting = new setting();
            setting.ShowDialog();

        }

        private void delgenuinebutton_Click(object sender, EventArgs e)
        {
            delgenuine delgenuine = new delgenuine();
            delgenuine.ShowDialog();
        }
    }
}

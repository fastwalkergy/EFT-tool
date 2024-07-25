using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFT_tool
{
    public partial class delgenuine : Form
    {
        private static string pathParameter = ""; // path路径初始为空字符串
        string keyName = "SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\EscapeFromTarkov";
        public delgenuine()
        {
            InitializeComponent();
            using (RegistryKey key = Registry.LocalMachine.CreateSubKey(keyName))
            {
                if (key != null)
                {
                    // 读取一个字符串值
                    string selectedFolderPathKey = key.GetValue("selectedFolderPath") as string;
                    if (selectedFolderPathKey != null)
                    {
                        pathParameter = selectedFolderPathKey + @"\Install_EFT";
                    }
                };
            }
        }

        private void PrintToTextBox(string text)
        {
           
             this.input1.AppendText(text + Environment.NewLine);
            
        }

        private async void delgenuinebutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pathParameter))
            {
                // 另一个线程中执行
                await Task.Run(() =>
                {
                    using (RegistryKey key = Registry.LocalMachine.CreateSubKey(keyName))
                    {
                        if (key != null)
                        {
                            PrintToTextBox("开始删除注册表：");
                            // 读取一个字符串值
                            if (key.GetValue("InstallLocation") as string != null)
                            {
                                key.DeleteValue("InstallLocation");
                                PrintToTextBox("删除InstallLocation注册表成功");
                            }
                            if (key.GetValue("Launcher") as string != null)
                            {
                                key.DeleteValue("Launcher");
                                PrintToTextBox("删除Launcher注册表成功");
                            }
                            if (key.GetValue("UninstallString") as string != null)
                            {
                                key.DeleteValue("UninstallString");
                                PrintToTextBox("删除UninstallString注册表成功");
                            }
                        }
                    }
                    if (Directory.Exists(pathParameter))
                    {
                        try
                        {
                            Directory.Delete(pathParameter, true);
                            PrintToTextBox("删除EFT验证目录成功");
                        }
                        catch (IOException ex)
                        {
                            Console.WriteLine($"删除文件夹时出错: {ex.Message}");
                        }
                    }
                    PrintToTextBox("删除已完成");
                });
            }
            else
            {
                MessageBox.Show($"请先选择过验证路径", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

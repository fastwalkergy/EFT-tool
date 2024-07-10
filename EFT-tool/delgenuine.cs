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
                        pathParameter = selectedFolderPathKey;
                    }
                };
            }
        }

        private void PrintToTextBox(string text)
        {
            if (input1.InvokeRequired)
            {
                input1.Invoke(new Action<string>(PrintToTextBox), text);
            }
            else
            {
                this.input1.AppendText(text + Environment.NewLine);
            }
        }

        private async void delgenuinebutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pathParameter))
            {
                // 另一个线程中执行
                await Task.Run(() =>
                {
                    PrintToTextBox("开始删除注册表：");
                    using (RegistryKey key = Registry.LocalMachine.CreateSubKey(keyName))
                    {
                        if (key != null)
                        {
                            // 读取一个字符串值
                            if (key.GetValue("InstallLocation") as string != null)
                            {
                                key.DeleteValue("InstallLocation");
                            }

                        }

                        // 添加一个名为 "Version" 的字符串值
                        key.SetValue("InstallLocation", pathParameter);
                        /*
                        key.SetValue("InstallLocation", pathParameter);
                        key.SetValue("InstallLocation", pathParameter);
                        PrintToTextBox("正在添加InstallLocation注册表");
                        PrintToTextBox("正在添加InstallLocation注册表");
                        */
                        PrintToTextBox("正在添加InstallLocation注册表");
                        string InstallLocation = key.GetValue("InstallLocation") as string;
                        if (InstallLocation == null)
                        {
                            PrintToTextBox("添加InstallLocation注册表失败！");
                        }
                        else
                        {
                            PrintToTextBox("注册表全部添加成功");
                        }
                    }
                    //开始创建文件夹
                    PrintToTextBox("开始创建EFT文件夹");
                    if (Directory.Exists(pathParameter))
                    {
                        PrintToTextBox("文件夹已存在，跳过创建");
                    }
                    else
                    {
                        Directory.CreateDirectory(pathParameter);
                        PrintToTextBox("正在创建EFT文件夹");
                    }
                    //开始创建文件
                    PrintToTextBox("开始创建文件：");
                    PrintToTextBox("正版验证已完成，Enjoy！");
                    MessageBox.Show($"正版验证已完成！", "成功");
                });
            }
            else
            {
                MessageBox.Show($"请先选择过验证路径", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

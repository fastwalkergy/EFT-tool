using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFT_tool
{
    public partial class setting : Form
    {
        string keyName = "SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\EscapeFromTarkov";
        private static string pathParameter = ""; // path路径初始为空字符串
        public setting()
        {
            InitializeComponent();
            //string selectedFolderPathKey = keyName + @"\selectedFolderPath";
            // 创建或打开注册表项
            using (RegistryKey key = Registry.LocalMachine.CreateSubKey(keyName))
            {
                if (key != null)
                {
                    // 读取一个字符串值
                    string selectedFolderPathKey = key.GetValue("selectedFolderPath") as string;
                    if (selectedFolderPathKey != null)
                    {
                        this.pathtxt.Text = "已选择文件夹：" + selectedFolderPathKey;
                        pathParameter = selectedFolderPathKey;
                    }
                };
            }
        }

        private void pathbutton_Click(object sender, EventArgs e)
        {
            using (var dialog = new CommonOpenFileDialog())
            {
                dialog.IsFolderPicker = true;
                dialog.Title = "请选择文件夹";
                if (!string.IsNullOrEmpty(pathParameter)) { 
                    dialog.InitialDirectory = pathParameter; 
                }else
                {
                    dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                }
                CommonFileDialogResult result = dialog.ShowDialog();
                if (result == CommonFileDialogResult.Ok)
                {
                    string selectedFolderPath = dialog.FileName;
                    //MessageBox.Show("已选择文件夹：" + selectedFolderPath);
                    this.pathtxt.Text = "已选择文件夹：" + selectedFolderPath;
                    try
                    {
                        // 创建或打开注册表项
                        using (RegistryKey key = Registry.LocalMachine.CreateSubKey(keyName))
                        {
                            // 添加一个名为 "Version" 的字符串值
                            key.SetValue("selectedFolderPath", selectedFolderPath);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

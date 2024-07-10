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
using System.Windows.Input;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace EFT_tool
{
    public partial class genuine : Form
    {
        private static int regok = 0;
        private static int fileok = 0;
        private static string pathParameter = ""; // path路径初始为空字符串
        string keyName = "SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\EscapeFromTarkov";
        public genuine()
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
            // 检查是否需要在主线程上执行更新
            if (input1.InvokeRequired)
            {
                // 使用 Invoke 方法在主线程上执行更新
                input1.Invoke(new Action<string>(PrintToTextBox), text);
            }
            else
            {
                // 在 TextBox 中追加新的文本
                this.input1.AppendText(text + Environment.NewLine);
            }
        }

        private void addfile(string name)
        {
            string filePath = System.IO.Path.Combine(pathParameter, name); // 显式地使用 System.IO.Path
            FileStream fs = File.Create(filePath);
            fs.Close();
            if (File.Exists(filePath))
            {
               input1.AppendText($"创建{name}文件成功" + Environment.NewLine); 
            }
        }


        private async void startdelgenuinebutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pathParameter))
            {
                // 另一个线程中执行
                await Task.Run(() =>
                {
                    PrintToTextBox("开始添加注册表：");
                    using (RegistryKey key = Registry.LocalMachine.CreateSubKey(keyName))
                    {
                        regok = 1;
                        // 添加一个名为 "Version" 的字符串值
                        key.SetValue("InstallLocation", pathParameter);
                        key.SetValue("Launcher", pathParameter + @"\EscapeFromTarkov.exe");
                        key.SetValue("UninstallString", pathParameter + @"Uninstall.exe");
                        PrintToTextBox("正在添加InstallLocation注册表");
                        //string InstallLocation = key.GetValue("InstallLocation") as string;
                        if (key.GetValue("InstallLocation") as string != null)
                        {
                            PrintToTextBox("添加Launcher注册表");
                        }else if (key.GetValue("Launcher") as string != null) 
                        {
                            PrintToTextBox("添加Launcher注册表");
                        }else if (key.GetValue("UninstallString") as string != null)
                        {
                            PrintToTextBox("添加UninstallString注册表");
                        }
                        else
                        {
                            regok = 0;
                            PrintToTextBox("注册表添加失败，请检查！！");
                        }
                    }
                    //开始创建文件夹
                    PrintToTextBox("开始创建文件夹：");
                    PrintToTextBox("正在创建EFT文件夹");
                    if (Directory.Exists(pathParameter))
                    {
                        PrintToTextBox("EFT验证文件夹已存在，跳过创建");
                    }
                    else
                    {
                        Directory.CreateDirectory(pathParameter);
                        PrintToTextBox("正在创建EFT验证文件夹");
                    }
                    PrintToTextBox("正在创建BattlEye文件夹");
                    if (Directory.Exists(pathParameter + @"\BattlEye"))
                    {
                        PrintToTextBox("BattlEye文件夹已存在，跳过创建");
                    }
                    else
                    {
                        Directory.CreateDirectory(pathParameter + @"\BattlEye");
                        PrintToTextBox("正在创建BattlEye文件夹");
                    }
                    //开始创建文件
                    PrintToTextBox("开始创建文件：");
                    addfile("Uninstall.exe");
                    addfile("ConsistencyInfo");
                    addfile("UnityCrashHandler64.exe");
                    addfile("WinPixEventRuntime.dll");
                    addfile("BattlEye\\BEClient_x64.dll");
                    addfile("EscapeFromTarkov.exe");
                    fileok = 1;
                    //PrintToTextBox("正在创建Uninstall.exe文件");
                    /*
                    string path1 = pathParameter + @"Uninstall.exe";
                    string path2 = pathParameter + @"ConsistencyInfo";
                    FileStream fs = File.Create(path1);
                    fs.Close();
                    if (File.Exists(path1))
                    {
                        PrintToTextBox("创建Uninstall.exe成功");
                    }*/
                    if (regok == 1 && fileok == 1)
                    {
                        PrintToTextBox("正版验证已完成，Enjoy！");
                        MessageBox.Show($"正版验证已完成！", "成功");
                    }
                    else
                    {
                        PrintToTextBox("正版验证出错，请检查");
                        MessageBox.Show($"正版验证出错，请检查！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            }
            else
            {
                MessageBox.Show($"请先选择过验证路径", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

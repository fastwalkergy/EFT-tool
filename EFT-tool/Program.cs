using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFT_tool
{
    internal static class Program
    {
        static Mutex mutex = new Mutex(true, "{6BB1F385-2B54-4EAC-B37F-2F3F098CB0EB}");
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 检查程序是否已经在运行
            if (!mutex.WaitOne(TimeSpan.Zero, true))
            {
                MessageBox.Show("程序已经在运行中! \n请不要多次运行", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine("程序已经在运行中！");
                return;
            }

            // 释放 Mutex
            mutex.ReleaseMutex();

            // 检查当前用户是否为管理员
            if (!IsAdministrator())
            {
               // MessageBox.Show("当前用户不是管理员，正在请求管理员权限...", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RunAsAdministrator();
                return; // 以管理员权限重新启动后，程序会终止当前实例
            }

            // 启动应用程序
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main());
        }

        // 检查当前用户是否为管理员
        private static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        // 以管理员权限重新启动程序
        private static void RunAsAdministrator()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = true;
            startInfo.WorkingDirectory = Environment.CurrentDirectory;
            startInfo.FileName = Process.GetCurrentProcess().MainModule.FileName;
            startInfo.Verb = "runas"; // 使用管理员权限运行
            try
            {
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("以管理员权限启动失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Environment.Exit(0); // 退出当前实例
        }
    }
}

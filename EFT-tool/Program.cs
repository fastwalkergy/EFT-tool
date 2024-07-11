using System;
using System.Collections.Generic;
using System.Linq;
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
            if (!mutex.WaitOne(TimeSpan.Zero, true))
            {
                MessageBox.Show("程序已经在运行中! \n 请不要多次运行","提醒");
                Console.WriteLine("程序已经在运行中！");
                return;
            }
            // 在程序结束时，释放互斥体
            mutex.ReleaseMutex();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main());
        }
    }
}

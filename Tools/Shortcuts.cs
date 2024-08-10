using System;
using System.Diagnostics;
using static MiniTools.Tools.RegistryHelper;
namespace MiniTools.Tools
{
    public class Shortcuts
    {
        RegistryHelper register = new RegistryHelper();

        /// <summary>
        /// 这里是快捷方式小箭头的函数
        /// </summary>
        public object ShortCuts(bool status)
        {

            string subKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Shell Icons";
            string keyName = "29";
            string keyValue = @"C:\Windows\system32\imageres.dll,197";
            if (status)
            {
                object bbb = register.WriteValue(keyName, keyValue, subKey, RegDomain.LocalMachine);
                RestartExplorer();
                return bbb;
            }
            else {
                object bbb = register.DeleteValue(keyName,subKey, RegDomain.LocalMachine);
                RestartExplorer();
                return bbb;

            }
        }
        public void RestartExplorer() {
            try
            {
                // 获取所有名为Explorer.exe的进程
                Process[] explorerProcesses = Process.GetProcessesByName("explorer");

                // 遍历并结束每个进程
                foreach (Process process in explorerProcesses)
                {
                    process.Kill();
                    process.WaitForExit(); // 等待进程结束
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("发生错误：" + ex.Message);
            }
        }
    }
}

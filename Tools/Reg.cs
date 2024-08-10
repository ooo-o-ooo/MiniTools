using System;
using Microsoft.Win32;
namespace MiniTools.Tools
{

    public class RegistryCurl
    {
        // 读取注册表项的值
        public  bool  ReadValue(string keyPath, string valueName)
        {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(keyPath))
            {
                if (key != null)
                {
                    String value =  key.GetValue(valueName) as string;
                    Console.WriteLine("VALUE获取:"+ value);

                    if (value == null)
                        return false;
                    else
                        return true;
                }
                return false;
            }
        }
        // 写入注册表项的值
        public  bool  WriteValue(string keyPath, string valueName, string value)
        {
            using (RegistryKey key = Registry.LocalMachine.CreateSubKey(keyPath))
            {
                if (key != null)
                {
                    key.SetValue(valueName, value);

                    return true;
                }
            }
            return false;
        }

        // 删除注册表项的值
        public  bool DeleteValue(string keyPath, string valueName)
        {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(keyPath, true))
            {
                if (key != null)
                {
                    key.DeleteValue(valueName, false);
                    return true;
                }
            }
            return false;
        }

    }















}

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTools.Tools {

    public class RegistryHelper
    {
        /// <summary>  
        /// 注册表基项域  
        /// </summary>  

        public enum RegDomain
        {
            /// <summary>  
            /// 对应于HKEY_CLASSES_ROOT 主键  
            /// </summary>  
            ClassesRoot = 0,
            /// <summary>  
            /// 对应于HKEY_CURRENT_USER 主键  
            /// </summary>  
            CurrentUser = 1,
            /// <summary>  
            /// 对应于 HKEY_LOCAL_MACHINE 主键  
            /// </summary>  
            LocalMachine = 2,
            /// <summary>  
            /// 对应于 HKEY_USER 主键  
            /// </summary>  
            User = 3,
            /// <summary>  
            /// 对应于HEKY_CURRENT_CONFIG 主键  
            /// </summary>  
            CurrentConfig = 4,
            /// <summary>  
            /// 对应于HKEY_PERFORMANCE_DATA 主键  
            /// </summary>  
            PerformanceData = 5
        }

        protected RegistryKey GetRegDomain(RegDomain regDomain)
        {
            ///创建基于注册表基项的节点  
            RegistryKey key;

            #region 判断注册表基项域  
            switch (regDomain)
            {
                case RegDomain.ClassesRoot:
                    key = Registry.ClassesRoot; break;
                case RegDomain.CurrentUser:
                    key = Registry.CurrentUser; break;
                case RegDomain.LocalMachine:
                    key = Registry.LocalMachine; break;
                case RegDomain.User:
                    key = Registry.Users; break;
                case RegDomain.CurrentConfig:
                    key = Registry.CurrentConfig; break;
                case RegDomain.PerformanceData:
                    key = Registry.PerformanceData; break;
                default:
                    key = Registry.LocalMachine; break;
            }
            #endregion
            return key;
        }

        public RegistryHelper() {
        }
        // 读取注册表项中的值
        public object ReadValue(string keyName, String subKey,RegDomain regDomain)
        {
            RegistryKey key = GetRegDomain(regDomain).OpenSubKey(subKey);
            using (key) 
            {
                if (key != null)
                {
                    return key.GetValue(keyName);
                }
                return null; // 如果键不存在，则返回null
            }
        }

        // 写入注册表项中的值
        public object WriteValue(string keyName, string value, String subKey, RegDomain regDomain)
        {
            RegistryKey key = GetRegDomain(regDomain).OpenSubKey(subKey,true);
            {
                key.SetValue(keyName, value);
                return "删除成功";
            }
        }

        // 删除注册表项中的值
        public object DeleteValue(string keyName, String subKey, RegDomain regDomain)
        {
            RegistryKey key = GetRegDomain(regDomain).OpenSubKey(subKey,true);
            {
                if (key != null)
                {
                    key.DeleteValue(keyName, false);
                }
                return "恢复成功";
            }
        }

        // 检查注册表项是否存在
        public static bool KeyExists(String subKeyPath)
        {
            return Registry.CurrentUser.OpenSubKey(subKeyPath) != null;
        }

        // 创建注册表项（如果尚不存在）
        public static void CreateKey(String subKeyPath)
        {
            Registry.CurrentUser.CreateSubKey(subKeyPath);
        }

        // 删除整个注册表项（谨慎使用）
        public static void DeleteKey(String subKeyPath)
        {
            Registry.CurrentUser.DeleteSubKeyTree(subKeyPath, false);
        }
    }
}
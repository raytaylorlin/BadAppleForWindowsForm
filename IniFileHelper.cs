using System.Runtime.InteropServices;
using System.Text;
using System.IO;

/* 用法：
 * IniFile iniFile=new IniFile(@"C:\test.ini");
 * iniFile.IniWriteValue("section1","key1","value1");
 * iniFile.IniWriteValue("section2","key2","value2");
 * iniFile.IniWriteValue("section3","key3","value3");
 * string value1=iniFile.IniReadValue("section1","key1");
 * string value2=iniFile.IniReadValue("section2","key2");
 * string value3=iniFile.IniReadValue("section3","key3");
 */

/// <summary>
/// ini文件读写类
/// </summary>
namespace BadAppleForWindowsForm
{
    public class IniFileHelper
    {
        public string path;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        /// <summary>
        /// ini文件构造函数
        /// </summary>
        /// <param name="INIPath">ini文件路径</param>
        public IniFileHelper(string INIPath)
        {
            path = INIPath;
        }

        /// <summary>
        /// ini文件初始化（主要为了防止当ini文件存在时直接写入）
        /// </summary>
        public void IniFileInit()
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        /// <summary>
        /// 写入ini文件
        /// </summary>
        /// <param name="Section">配置项所属节</param>
        /// <param name="Key">配置关键字名</param>
        /// <param name="Value">配置项的值</param>
        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.path);
        }

        /// <summary>
        /// 读取ini文件
        /// </summary>
        /// <param name="Section">配置项所属节</param>
        /// <param name="Key">配置关键字名</param>
        /// <returns>配置项的值</returns>
        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, this.path);
            return temp.ToString();
        }
    }
}
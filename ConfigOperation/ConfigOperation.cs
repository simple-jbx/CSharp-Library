using System.Configuration;
using System.Windows.Forms;

namespace ConfigOperation
{
    /// <summary>
    /// 有关C#中配置文件的自定义操作
    /// </summary>
    public class ConfigOperation
    {
        private ConfigOperation() { }

        /// <summary>
        /// 读取配置文件中key对应的value
        /// </summary>
        /// <param name="key">要读取的key</param>
        /// <returns>返回key对应的value</returns>
        public static string ReadConfig(in string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        /// <summary>
        /// 根据key将对应的value写入配置文件
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="filePath">配置文件路径，默认为应用程序启动路径</param>
        public static void SetConfig(in string key, in string value, string filePath = "")
        {
            if(string.IsNullOrWhiteSpace(filePath))
            {
                filePath = Application.ExecutablePath;
            }
            Configuration config = ConfigurationManager.OpenExeConfiguration(filePath);
            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}

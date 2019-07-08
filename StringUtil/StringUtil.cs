using System;
using System.Text;

namespace StringUtil
{
    /// <summary>
    /// 字符串操作的常用自定义方法
    /// </summary>
    public class StringUtil
    {
        /// <summary>
        /// 将字符串截成指定长度的字符串
        /// </summary>
        /// <param name="str">原始字符串</param>
        /// <param name="len">要截取的长度</param>
        /// <param name="appendStr">末尾要追加的字符创默认为空</param>
        /// <returns></returns>
        public static string CutString(string str, int len = 30, string appendStr = "")
        {
            if (str == null || len < 0)
            {
                return "";
            }
            else if (str.Length <= len)
            {
                return str;
            }
            return str.Substring(0, len) + appendStr;
        }

        /// <summary>
        /// 以固定行长度显示字符串
        /// </summary>
        /// <param name="str">原始字符串</param>
        /// <param name="lineLong">单行长度（默认30）</param>
        /// <returns></returns>
        public static string FormatString(string str, int lineLong = 30)
        {
            if (str == null || lineLong < 0)
            {
                return "";
            }
            else if (str.Length <= lineLong)
            {
                return str;
            }

            StringBuilder sb = new StringBuilder();
            while (str.Length > lineLong)
            {
                sb.Append(str.Substring(0, lineLong) + Environment.NewLine);
                str = str.Substring(lineLong);
            }
            if (str.Length > 0)
            {
                sb.Append(Environment.NewLine + str);
            }
            return sb.ToString();
        }
    }
}

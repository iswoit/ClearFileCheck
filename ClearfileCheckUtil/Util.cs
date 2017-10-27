using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ClearfileCheckUtil
{
    public static class Util
    {


        /// <summary>
        /// 将mdd替换成当天(现在只写了mdd)
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string Filename_Date_Convert(string fileName)
        {
            DateTime dtNow = DateTime.Now;
            char[] arr_mdd_convert = { '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c' };
            string replacement = String.Format("{0}{1}", arr_mdd_convert[dtNow.Month], dtNow.Day.ToString().PadLeft(2, '0'));

            string strReturn = Regex.Replace(fileName, "mdd", replacement, RegexOptions.IgnoreCase);
            return strReturn;
        }
    }
}

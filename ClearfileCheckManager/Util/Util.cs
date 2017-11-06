﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ClearfileCheckManager
{
    public static class Util
    {
        private static char[] arr_mdd_convert;  // mdd格式的字典数组
        static Util()
        {
            arr_mdd_convert = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c' };
        }

        /// <summary>
        /// 将yyyymmdd，mmdd，mdd替换成当天
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string Filename_Date_Convert(string fileName)
        {
            string strTmp = fileName;   // 返回值

            DateTime dtNow = DateTime.Now;

            string yyyymmdd_replacement = dtNow.ToString("yyyyMMdd");
            string mmdd_replacement = string.Format("{0}{1}", dtNow.Month.ToString().PadLeft(2, '0'), dtNow.Day.ToString().PadLeft(2, '0'));
            string mdd_replacement = string.Format("{0}{1}", arr_mdd_convert[dtNow.Month - 1], dtNow.Day.ToString().PadLeft(2, '0'));

            strTmp = Regex.Replace(strTmp, "yyyymmdd", yyyymmdd_replacement, RegexOptions.IgnoreCase);  // 1.替换yyyymmdd
            strTmp = Regex.Replace(strTmp, "mmdd", mmdd_replacement, RegexOptions.IgnoreCase);          // 2.替换mmdd
            strTmp = Regex.Replace(strTmp, "mdd", mdd_replacement, RegexOptions.IgnoreCase);            // 3.替换mdd
            return strTmp;
        }


        /// <summary>
        /// 文件名里是否有日期通配符
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool Filename_Contain_DatePattern(string fileName)
        {

            if (Regex.IsMatch(fileName, "yyyymmdd", RegexOptions.IgnoreCase) || Regex.IsMatch(fileName, "mmdd", RegexOptions.IgnoreCase) || Regex.IsMatch(fileName, "mdd", RegexOptions.IgnoreCase))
                return true;
            else
                return false;
        }


        /// <summary>
        /// 获取文件md5码
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string GetMD5HashFromFile(string fileName)
        {
            try
            {
                FileStream file = new FileStream(fileName, FileMode.Open);
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("GetMD5HashFromFile() fail, error:" + ex.Message);
            }
        }


        /// <summary>
        /// 获取下一个执行时间
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="secondSpan"></param>
        /// <returns></returns>
        public static DateTime GetNextExecuteTime(DateTime dt,int secondSpan)
        {
            DateTime dtReturn = dt.AddSeconds(secondSpan);
            return dtReturn;
        }



    }
}

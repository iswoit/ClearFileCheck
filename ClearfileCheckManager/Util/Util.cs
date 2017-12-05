using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using ICSharpCode.SharpZipLib;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.BZip2;

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
            string yymmdd_replacement = dtNow.ToString("yyMMdd");
            string mmdd_replacement = string.Format("{0}{1}", dtNow.Month.ToString().PadLeft(2, '0'), dtNow.Day.ToString().PadLeft(2, '0'));
            string mdd_replacement = string.Format("{0}{1}", arr_mdd_convert[dtNow.Month - 1], dtNow.Day.ToString().PadLeft(2, '0'));

            strTmp = Regex.Replace(strTmp, "yyyymmdd", yyyymmdd_replacement, RegexOptions.IgnoreCase);  // 1.替换yyyymmdd
            strTmp = Regex.Replace(strTmp, "yymmdd", yymmdd_replacement, RegexOptions.IgnoreCase);      // 2.替换yymmdd
            strTmp = Regex.Replace(strTmp, "mmdd", mmdd_replacement, RegexOptions.IgnoreCase);          // 3.替换mmdd
            strTmp = Regex.Replace(strTmp, "mdd", mdd_replacement, RegexOptions.IgnoreCase);            // 4.替换mdd
            return strTmp;
        }


        /// <summary>
        /// 文件名里是否有日期通配符
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool Filename_Contain_DatePattern(string fileName)
        {

            if (Regex.IsMatch(fileName, "yyyymmdd", RegexOptions.IgnoreCase) || Regex.IsMatch(fileName, "yymmdd", RegexOptions.IgnoreCase) || Regex.IsMatch(fileName, "mmdd", RegexOptions.IgnoreCase) || Regex.IsMatch(fileName, "mdd", RegexOptions.IgnoreCase))
                return true;
            else
                return false;
        }


        /// <summary>
        /// 文件名里是否有当天的日期
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool Filename_Contain_DateString(string fileName)
        {
            DateTime dtNow = DateTime.Now;
            string yyyymmdd_replacement = dtNow.ToString("yyyyMMdd");
            string yymmdd_replacement = dtNow.ToString("yyMMdd");
            string mmdd_replacement = string.Format("{0}{1}", dtNow.Month.ToString().PadLeft(2, '0'), dtNow.Day.ToString().PadLeft(2, '0'));
            string mdd_replacement = string.Format("{0}{1}", arr_mdd_convert[dtNow.Month - 1], dtNow.Day.ToString().PadLeft(2, '0'));


            if (Regex.IsMatch(fileName, yyyymmdd_replacement, RegexOptions.IgnoreCase) || Regex.IsMatch(fileName, yymmdd_replacement, RegexOptions.IgnoreCase) || Regex.IsMatch(fileName, mmdd_replacement, RegexOptions.IgnoreCase) || Regex.IsMatch(fileName, mdd_replacement, RegexOptions.IgnoreCase))
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
                StringBuilder sb = new StringBuilder();
                using (FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                    byte[] retVal = md5.ComputeHash(file);
                    file.Close();

                    for (int i = 0; i < retVal.Length; i++)
                    {
                        sb.Append(retVal[i].ToString("x2"));
                    }
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("解析MD5出错:" + ex.Message);
            }
        }


        /// <summary>
        /// 获取下一个执行时间
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="secondSpan"></param>
        /// <returns></returns>
        public static DateTime GetNextExecuteTime(DateTime dt, int secondSpan)
        {
            DateTime dtReturn = dt.AddSeconds(secondSpan);
            return dtReturn;
        }


        /// <summary>
        /// 解压zip文件(需要修改！，文件存在就不解压，只判断md5？)
        /// </summary>
        /// <param name="sourceFile"></param>
        /// <param name="targetPath"></param>
        public static void Decompress_zip(string sourceFile, string targetPath)
        {
            if (!File.Exists(sourceFile))
            {
                throw new FileNotFoundException(string.Format("未能找到文件 '{0}' ", sourceFile));
            }
            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }
            //File.OpenRead(sourceFile)
            //new FileStream(sourceFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
            using (ZipInputStream s = new ZipInputStream(new FileStream(sourceFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
            {
                ZipEntry theEntry;
                while ((theEntry = s.GetNextEntry()) != null)
                {
                    string directorName = Path.Combine(targetPath, Path.GetDirectoryName(theEntry.Name));
                    string fileName = Path.Combine(directorName, Path.GetFileName(theEntry.Name));

                    if (File.Exists(fileName))
                        File.Delete(fileName);

                    // 创建目录
                    if (directorName.Length > 0)
                    {
                        Directory.CreateDirectory(directorName);
                    }
                    if (fileName != string.Empty)
                    {
                        using (FileStream streamWriter = File.Create(fileName))
                        {
                            int size = 4096;
                            byte[] data = new byte[4 * 1024];
                            while (true)
                            {
                                size = s.Read(data, 0, data.Length);
                                if (size > 0)
                                {
                                    streamWriter.Write(data, 0, size);
                                }
                                else break;
                            }
                        }
                    }
                }
            }
            return;
        }


        /// <summary>
        /// 解压bz2文件(需要修改！，文件存在就不解压，只判断md5？)
        /// </summary>
        /// <param name="zipfilename"></param>
        /// <param name="unzipfilename"></param>
        public static void Decompress_bz2(string zipfilename, string unzipfilename)
        {
            string dir = unzipfilename;
            //解压文件夹为空时默认与压缩文件同一级目录下，跟压缩文件同名的文件夹   
            if (dir == "")
                dir = zipfilename.Replace(Path.GetFileName(zipfilename), Path.GetFileNameWithoutExtension(zipfilename));
            if (!dir.EndsWith(@"\"))
                dir += @"\";
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            //创建压缩文件的输入流实例
            //File.OpenRead(zipfilename)
            //new FileStream(zipfilename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
            using (BZip2InputStream zipFile = new BZip2InputStream(new FileStream(zipfilename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
            {
                //创建目标文件的流
                using (FileStream destFile = File.Open(dir + Path.GetFileNameWithoutExtension(zipfilename), FileMode.Create))
                {
                    int buffersize = 2048;//缓冲区的尺寸，一般是2048的倍数
                    byte[] FileData = new byte[buffersize];//创建缓冲数据
                    while (buffersize > 0)//一直读取到文件末尾
                    {
                        buffersize = zipFile.Read(FileData, 0, buffersize);//读取压缩文件数据
                        destFile.Write(FileData, 0, buffersize);//写入目标文件
                    }
                }
            }
        }

    }
}

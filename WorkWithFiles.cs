using System;
using System.IO;
using System.IO.Compression;

namespace HomeWork6old
{
    public class WorkWithFiles
    {
        /// <summary>
        /// Функция компрессора
        /// </summary>
        /// <param name="path"></param>
        public static void CompressZip(string path)
        {
            string compressed = @"D:\HomeWork6\file.zip";
            using FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
            using FileStream zipfileStream = File.Create(compressed);
            using GZipStream gZipStream = new GZipStream(zipfileStream, CompressionMode.Compress);
            fileStream.CopyTo(gZipStream);
        }

        /// <summary>
        /// Извлекаем число из файла
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        internal static int ReadNumber(string str)
        {
            try
            {
                string line;
                using (StreamReader streamReader = new StreamReader(str))
                {
                    line = streamReader.ReadLine();
                }

                return int.Parse(line ?? throw new InvalidOperationException());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
        }
    }
}
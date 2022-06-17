using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp862
{
    /// <summary>
    /// класс работы с файлами
    /// </summary>
    static public class MyWorkWithFile
    {
        /// <summary>
        /// считаем объем всех файлов в указанной директории (и в глубине дирректории)
        /// </summary>
        /// <param name="info"> заданная директория </param>
        /// <returns> общий объем файлов </returns>
        static public long FileSize(DirectoryInfo info)
        {
            long total = 0;
            try
            {
                foreach (FileInfo file in info.GetFiles())
                {
                    Console.WriteLine("ОбЪем файла {0} : {1}", file, file.Length);
                    total += +file.Length;
                }

                foreach (DirectoryInfo dir in info.GetDirectories())
                {
                    total += FileSize(dir);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Процесс не удался: {0}", e.Message);
            }

            return total;
        }
    }
}

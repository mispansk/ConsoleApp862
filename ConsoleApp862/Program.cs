using System;
using System.IO;

namespace ConsoleApp862
{
    // Задание 8.6.2 программа, которая считает размер папки на диске
    class Program
    {                   
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var dirName = new DirectoryInfo(@"C:\Work\skillFactori\123"); // Прописываем путь к директории 
            long tottal = 0;

            if (dirName.Exists)
            {
                 tottal = MyWorkWithFile.FileSize(dirName);
            }
            else
            {
                Console.WriteLine("Некорректно указан путь");
            }
            Console.WriteLine("Oбъем файлов {0}", tottal);
            Console.ReadKey();
        }
    }
}
using System;
using System.Globalization;
using static HomeWork6old.Writer;

namespace HomeWork6old
{
    class Program
    {
        /// <summary>
        /// Основной метод, что запускает вывод
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            ReadableFileInfo();
            Console.WriteLine("1 - Записать в файл.\n2 - Вывести в консоль кол-во групп.");
            var input = Console.ReadKey().Key;
            switch (input)
            {
                case ConsoleKey.D1:
                    WriteInFile();
                    break;
                case ConsoleKey.D2:
                    WriteInConsole();
                    break;
                default:
                    Console.WriteLine("\nВыход");
                    break;
            }
        }
    }
}
using System;

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
            Writer.ReadableFileInfo();
            Console.WriteLine("1 - Записать в файл.\n2 - Вывести в консоль кол-во групп.");
            var input = Console.ReadKey().Key;
            switch (input)
            {
                case ConsoleKey.D1:
                    Writer.WriteInFile();
                    break;
                case ConsoleKey.D2:
                    Writer.WriteInConsole();
                    break;
                default:
                    Console.WriteLine("\nВыход");
                    break;
            }
        }
    }
}
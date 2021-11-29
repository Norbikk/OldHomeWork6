using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HomeWork6old
{
    public class Writer
    {
        private static readonly int _n = WorkWithFiles.ReadNumber(@"D:\HomeWork6\numbers.txt"); //Создаем инт из файла

        private static readonly List<List<int>>
            _groupsNums = CoreComputation.NumberGroup(_n); //Создаем лист из сгруппированных чисел

        private static readonly string _path = @"D:\HomeWork6\file.txt"; //Создаем стрингу с путем к файлу
        /// <summary>
        ///     Записываем данные в файл
        /// </summary>
        public static void WriteInFile()
        {
            var groupNumber = 1;
            var dateTime = DateTime.Now; //Запоминаем в dateTime время
            using (var streamWriter = new StreamWriter(_path)) //Запускаем стримрайтер
            {
                streamWriter.Write(string.Join("\r\n",
                                       _groupsNums.Select(gr => $"Группа {groupNumber++} : " + string.Join(", ", gr))) +
                                   "\r\n"); //Выводим в файл информацию
            }

            ElapsedTime(dateTime); //Подсчитываем время
            WouldCompress(); //Спрашиваем про архивацию
        }
        /// <summary>
        ///     Выводим информацию в консоль
        /// </summary>
        public static void WriteInConsole()
        {
            Console.WriteLine($"Колличество групп:{_groupsNums.Count}");
        }
        /// <summary>
        ///     Первая выводимая информация в консоли
        /// </summary>
        public static void ReadableFileInfo()
        {
            var str = @"D:\HomeWork6\numbers.txt";
            Console.WriteLine($"положите файл с числом по указаному пути {str}");
            var number = WorkWithFiles.ReadNumber(str);
            Console.WriteLine($"Получено число из файла: {number}");
        }

        /// <summary>
        ///     Вызывает метод архивации при нажатии Y
        /// </summary>
        private static void WouldCompress()
        {
            Console.WriteLine("Архивировать? y/n");
            var input = Console.ReadKey().Key;
            if (input == ConsoleKey.Y)
            {
                WorkWithFiles.CompressZip(_path);
                Console.WriteLine($"\nСжатие файла {_path} завершено.");
            }
            else
            {
                Console.WriteLine("\nВыход");
            }
        }
        /// <summary>
        ///     Дает информацию по кол-ву затраченного времени работы программы
        /// </summary>
        /// <param name="dateTime"></param>
        private static void ElapsedTime(DateTime dateTime)
        {
            var timeSpan = DateTime.Now.Subtract(dateTime);
            Console.WriteLine($"\nНа выполнение задачи потребовалось: {timeSpan.TotalSeconds} секунд");
        }
    }
}
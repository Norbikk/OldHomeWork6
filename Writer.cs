using System;
using System.IO;
using static HomeWork6old.CoreComputation;
using static HomeWork6old.WorkWithFiles;

namespace HomeWork6old
{
    public class Writer
    {
        private static readonly int _n = ReadNumber("numbers.txt"); //Создаем инт из файла
        
        private static readonly string _path = "file.txt"; //Создаем стрингу с путем к файлу
        /// <summary>
        ///     Записываем данные в файл
        /// </summary>
        public static void WriteInFile()
        {
            
            var dateTime = DateTime.Now; //Запоминаем в dateTime время
            using (var streamWriter = new StreamWriter(_path)) //Запускаем стримрайтер
            {
                int m = 0;
                int firstNum = 1;
                for (int i = 1; i <= _n; i++)
                {
                    if (i % firstNum == 0)
                    {
                        firstNum = i;
                        m++;
                       streamWriter.Write($"\nГруппа {m} : {i}");
                    }
                    else
                    {
                        streamWriter.Write($", {i}");
                    }
                }
               // streamWriter.WriteLine(GroupNumbers(_n));  //На случай того, если надо будет вернуть в CoreComputations,Но тот алгоритм очень долго высчитывает >300 000
            }
            ElapsedTime(dateTime); //Подсчитываем время
            WouldCompress(); //Спрашиваем про архивацию
        }
        /// <summary>
        ///     Выводим информацию в консоль
        /// </summary>
        public static void WriteInConsole()
        {
            Console.WriteLine($"\nКолличество групп: {GroupsCount(_n)}");
        }
        /// <summary>
        ///     Первая выводимая информация в консоли
        /// </summary>
        public static void ReadableFileInfo()
        {
            const string str = "numbers.txt";
            Console.WriteLine($"положите файл с числом по указаному пути bin/Debug/net5.0/{str}");
            var number = ReadNumber(str);
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
                CompressZip(_path);
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
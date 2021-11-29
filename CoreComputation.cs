using System.Collections.Generic;
using System.Linq;

namespace HomeWork6old
{
    public class CoreComputation
    {
        /// <summary>
        /// Создание листа с сгрупированными числами
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<List<int>> NumberGroup(int number)
        {
            List<List<int>> groups = new List<List<int>>(); // Создаем лист для списка групп
            
            if (number == 0) // Если число 0 то возвращаем пустой список
                return groups;
            groups.Add(new List<int>() {1}); // Запись единицы в первой группе
            
            if (number == 1) // Если число единица то возвращаем с одной группой
                return groups;
            
            List<int> numbers = Enumerable.Range(2, number - 1).ToList(); // Создание листа чисел > 1 и до заданного
            
            while (numbers.Any()) // Пока в листе есть хоть один элемент
            {
                List<int> group = numbers.ToList(); // Создание группы чисел
                
                for (int i = 0; i < group.Count; i++) // Проходимся по листу
                    group.RemoveAll(num => num != group[i] && num % group[i] == 0); // Удаляем кратные числа
                groups.Add(group); // Добавление группу в список
                numbers.RemoveAll(num => group.Contains(num)); // Удаление из листа чисел
            }
            return groups;
        }
    }
}
using System;

namespace HW_Exceptions_31._08._15
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Worker[] listWorkers = new Worker[5];
            FillWorkers(listWorkers);
            SortABC(listWorkers);
            FindExpiriance(listWorkers);
        }
        public static void FindExpiriance(Worker[] listWorkers)
        {
            Console.WriteLine("Введите минимальный стаж работника ");
            int expirience = 0;
            try
            {
                expirience = int.Parse(Console.ReadLine());
                int temp;
                Console.WriteLine("У следующих работников стаж больше {0} год.:", expirience);
                for (int i = 0; i < listWorkers.Length; i++)
                {
                    temp = 2015 - listWorkers[i].StartYearJob;

                    if (temp > expirience)
                    {
                        Console.WriteLine(listWorkers[i].SurnameAndInitials);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void FillWorkers(Worker[] listWorkers)
        {
            for (int i = 0; i < listWorkers.Length; i++)
            {
                try
                {
                    Console.WriteLine("Введите Фамилию и инициалы работника {0}", i + 1);
                    listWorkers[i].SurnameAndInitials = Console.ReadLine();
                    Console.WriteLine("Введите должность:");
                    listWorkers[i].Position = Console.ReadLine();
                    Console.WriteLine("Введите год поступления на работу (1950 - 2015):");
                    listWorkers[i].StartYearJob = int.Parse(Console.ReadLine());
                    if (listWorkers[i].StartYearJob > 2015 || listWorkers[i].StartYearJob < 1950)
                    {

                        throw new Exception("Ошибка. Данные введены не в правильном формате. Возможные значения 1950 - 2015");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public static void SortABC(Worker[] listWorkers)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < listWorkers.Length - 1; ++i)
                    if (listWorkers[i].SurnameAndInitials.CompareTo(listWorkers[i + 1].SurnameAndInitials) > 0)
                    {
                        string buf = listWorkers[i].SurnameAndInitials;
                        listWorkers[i].SurnameAndInitials = listWorkers[i + 1].SurnameAndInitials;
                        listWorkers[i + 1].SurnameAndInitials = buf;
                        flag = true;
                    }
            }
            Console.WriteLine("Отсортированный список:");
            for (int i = 0; i < listWorkers.Length; i++)
            {
                Console.WriteLine(listWorkers[i].SurnameAndInitials);
            }
        }
    }
}

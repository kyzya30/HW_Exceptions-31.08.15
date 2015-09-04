using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Price[] listShop = new Price[2];
            FillListShop(ref listShop);
            SortABC(ref listShop);
            ShowProducts(ref listShop);
        }
        public static void SortABC(ref Price[] shops)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < shops.Length - 1; ++i)
                    if (shops[i].ShopName.CompareTo(shops[i + 1].ShopName) > 0)
                    {
                        string buf = shops[i].ShopName;
                        shops[i].ShopName = shops[i + 1].ShopName;
                        shops[i + 1].ShopName = buf;
                        flag = true;
                    }
            }
            Console.WriteLine("Отсортированные магазины:");
            for (int i = 0; i < shops.Length; i++)
            {
                Console.WriteLine(shops[i].ShopName);
            }
        }
        public static void FillListShop(ref Price[] listShop)
        {
            try
            {
                for (int i = 0; i < listShop.Length; i++)
                {
                    Console.WriteLine("Введите название продукта:");
                    listShop[i].ProductName = Console.ReadLine();
                    Console.WriteLine("Введите название магазина:");
                    listShop[i].ShopName = Console.ReadLine();
                    Console.WriteLine("Введите цену:");
                    listShop[i].ProductPrice = int.Parse(Console.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private static void ShowProducts(ref Price[] listShop)
        {
            Console.WriteLine("Введите названия магазина, что бы узнать его товары:");
            try
            {
                string findShopName = Console.ReadLine();
                int ShowException = 0;
                for (int i = 0; i < listShop.Length; i++)
                {
                    if (findShopName == listShop[i].ShopName)
                    {
                        ShowException++;
                        Console.WriteLine("В данном магазине есть такие товары: {0} - Цена {1}", listShop[i].ProductName, listShop[i].ProductPrice);
                    }
                }
                if (ShowException == 0)
                {
                    throw new Exception("Данного магазина не существует!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

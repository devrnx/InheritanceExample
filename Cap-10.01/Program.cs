using Cap_10._01.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Cap_10._01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                string opt = Console.ReadLine();

                switch (opt)
                {
                    case "c":
                        Product p1 = RegistraProduto(opt);
                        list.Add(p1);
                        break;

                    case "u":
                        Product p2 = RegistraProduto(opt);
                        list.Add(p2);
                        break;

                    case "i":
                        Product p3 = RegistraProduto(opt);
                        list.Add(p3);
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAG:");
            Console.WriteLine();
            int count = 0;

            foreach (var item in list)
            {
                Console.WriteLine($"Product #{count + 1}");
                Console.WriteLine(item.priceTag() + "\n");
                count++;
            }

            Console.ReadLine();
        }

        public static Product RegistraProduto(string opt)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (opt == "u")
            {
                Console.Write("Manufacture date (DD/MM/YYYY): ");
                DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                Product product = new UsedProduct(name, price, manufactureDate);

                return product;
            }

            else if (opt == "i")
            {
                Console.Write("Customs fee: ");
                double customs = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new ImportedProduct(name, price, customs);

                return product;
            }

            else
            {
                Product product = new Product(name, price);

                return product;
            }
        }
    }
}

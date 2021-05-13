using System;
using System.Globalization;
using System.Collections.Generic;
using Ex_Prop_TagProduct.Entites;

namespace Ex_Prop_TagProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome program...\n");

            Console.Write("Enter the number of Products...: ");
            int nProducts = int.Parse(Console.ReadLine());

            List<Product> listProduct = new List<Product>();

            for (int i = 1; i <= nProducts; i++)
            {
                Console.WriteLine(); //Jump a line in execution;
                Console.Write("Common, used or imported (c/u/i)?...: ");
                char tProduct = char.Parse(Console.ReadLine());
                Console.Write("Name...: ");
                string name = Console.ReadLine();
                Console.Write("Price...: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (tProduct)
                {
                    case 'c':
                        {
                            listProduct.Add(new Product(name, price));
                            break;  
                        }
                    case 'u':
                        {
                            Console.Write("Manofacture date...: ");
                            DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                            listProduct.Add(new UsedProduct(name, price, manufactureDate));
                            break;
                        }
                    case 'i': 
                        {
                            Console.Write("Custom Fees...: ");
                            double customFees = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                            listProduct.Add(new ImportedProduct(name, price, customFees));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You don't choise a validate option for product");
                            break;
                        }
                }    
            }

            Console.WriteLine(); //Jump a line in execution;
            Console.WriteLine("PRICE TAGS...");
            foreach (Product product in listProduct)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}

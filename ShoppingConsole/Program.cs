using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> selection = new List<string>();
            List<string> quantity = new List<string>();
            bool flag = true;

            Console.WriteLine("---=== Welcome to E-Mart ===---");
            Console.WriteLine();

            do
            {
                Menu();

                Console.Write("Selection: ");

                selection.Add(Console.ReadLine());

                Console.Write("Quantity: ");

                quantity.Add(Console.ReadLine());

                Console.Write("Continue? Y/N:  ");

                if (Console.ReadLine().Equals("N"))
                    flag = false;

                Console.WriteLine();

            } while (flag);

            ShoppingCart(selection, quantity);
        }

        public static void Menu()
        {
            Console.WriteLine("Select your item and quantity:");
            Console.WriteLine("1. GorTex Boots");
            Console.WriteLine("2. GorTex Jacket");
            Console.WriteLine();
        }

        public static void ShoppingCart(List<String> selection, List<String> quantity)
        {

        }
    }
}

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
            string[,] items = new string[,] { { "Eggs", "10" }, { "Bread", "15" } };
            string input;
            int price = 0;
            int quantity;
            int index;
            
            for (int i=0;i<items)

            Console.WriteLine(items);

            do
            {
                input = Console.ReadLine();
                Console.WriteLine("Enter quantity: ");
                index = Convert.ToInt32(input) + 1;
                quantity = Convert.ToInt32(Console.ReadLine());
                price += quantity * Convert.ToInt32(items[index, 1]); // accessing price of item

            } while (input != "S");

            Console.WriteLine("Your total: " + price);
        }
    }
}

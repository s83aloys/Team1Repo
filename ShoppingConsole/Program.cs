using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingConsole
{
    class Program
    {
        public const double BOOTS_PRICE=4;
        public const double JACKET_PRICE = 4;
        static void Main(string[] args)
        {
            List<string> selection = new List<string>();
            bool flag = true;

            Console.WriteLine("---=== Welcome to E-Mart ===---");
            Console.WriteLine();

            do
            {
                Menu();

                Console.Write("Selection: ");

                selection.Add(Console.ReadLine());

                Console.Write("Continue? Y/N:  ");

                if (Console.ReadLine().Equals("N"))
                    flag = false;

                Console.WriteLine();

            } while (flag);



            Console.WriteLine("Your total purchase is $ {0}", ShoppingCart(selection));
            Console.Read();
        }

        public static void Menu()
        {
            Console.WriteLine("Select your item and quantity:");
            Console.WriteLine("1. GorTex Boots");
            Console.WriteLine("2. GorTex Jacket");
            Console.WriteLine();
        }

        public static double ShoppingCart(List<String> selection)
        {
            double pricetotal = 0;

            if (selection.Count() > 1)
            {
                for (int i = 0; i < selection.Count(); i++)
                {
                    if (i == 0)
                    {
                        if (selection[i].Equals("1"))
                        {
                            pricetotal += BOOTS_PRICE;
                        }
                        else
                        {
                            pricetotal += JACKET_PRICE;    
                        }
                        
                    }
                    else if (i > 0 && selection[i - 1].Equals(selection[i]))
                    {
                        if (selection[i].Equals("1"))
                        {
                            pricetotal += (BOOTS_PRICE * 0.7);
                        }
                        else
                        {
                            pricetotal += (JACKET_PRICE * 0.7);    
                        }
                                                
                    }
                    else if (i > 0 && !(selection[i - 1].Equals(selection[i])))
                    {
                                                
                        if (selection[i].Equals("1"))
                        {
                            pricetotal += (BOOTS_PRICE * 0.5);
                        }
                        else
                        {
                            pricetotal += (JACKET_PRICE * 0.5);
                        }
                    }
                }
            }
            else
            {
                if (selection[0].Equals("1"))
                {
                    pricetotal += BOOTS_PRICE;
                }
                else
                {
                    pricetotal += JACKET_PRICE;
                }
                        
            }

            return pricetotal;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscountEngine
{
    public class Discounts
    {
        public double priceTotal;

        public double GetDiscounts(Product[] product)
        {

            product = new Product[1];
            product[0].sku = "100.1";
            product[0].price = 120.0;
            product[1].sku = "100.1";
            product[1].price = 100.0;

            if (product.Count() > 1)
            {
                for (int i = 0; i < product.Count() - 1; i++)
                {
                    if (i == 0)
                    {
                        priceTotal += product[i].price;
                    }
                    else if (i > 0 && product[i - 1].sku.Equals(product[i].sku))
                    {
                        priceTotal += (product[i].price * 0.7);
                    }
                    else if (i > 0 && !(product[i - 1].sku.Equals(product[i].sku)))
                    {
                        priceTotal += (product[i].price * 0.5);
                    }
                }
            }
            else
            {
                priceTotal = product[0].price;
            }

            return priceTotal;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingcart
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int quantityApple = 0;
            int quantityOrange = 0;
            List<string> items = new List<string>();
            items.Add(Convert.ToString(Product.apples));
            items.Add(Convert.ToString(Product.apples));
            items.Add(Convert.ToString(Product.oranges));
            items.Add(Convert.ToString(Product.apples));

            for(int i = 0; i < items.Count; i++)
            {
                if(items[i] == "oranges")
                {
                    quantityOrange++;
                }
                else
                {
                    quantityApple++;
                }
            }

            double price = 0.60*quantityApple + 0.25*quantityOrange;
            Console.WriteLine(price);
            Console.ReadKey();
        }
    }
}

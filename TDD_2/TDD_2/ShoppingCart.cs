using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_2
{
    public class ShoppingCart
    {
        private Dictionary<string, double> _items = new Dictionary<string, double> { };
        public double _discount { get; private set; } = 0;

        public bool AddItems(string name, double price)
        {
            if(price >=0)
            _items.Add(name, price);
            return _items.ContainsKey(name);
        }

        public double CalculateTotalPrice()
        {
            double total = 0;
            foreach (var pair in _items)
            {
               
                total += pair.Value;
            }
            return total;
        }


        public double ApplyDiscount(double discount)
        {
            if (!(discount >= 0 && discount <= 1))
            {
                throw new Exception("That's an invalid discount!");
            }

            _discount = discount;

            double result = CalculateTotalPrice() * discount;

            return result;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joining_Data
{
    public class Order
    {
        public string CustomerName { get; set; }
        public string Item { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Order(string _name, string _item, decimal _price, int _quantity)
        {
            CustomerName = _name;
            Item = _item;
            Price = _price;
            Quantity = _quantity;
        }
    }
}

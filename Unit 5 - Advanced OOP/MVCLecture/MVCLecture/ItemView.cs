using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLecture
{
    public class ItemView
    {
        //property
        public Item DisplayItem { get; set; }

        //constructor
        public ItemView(Item _item)
        {
            DisplayItem = _item;
        }
        //method
        public void Display()
        {
            Console.WriteLine($"{DisplayItem.Name} ${DisplayItem.Price}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLecture
{
    internal class ItemController
    {
        //pretend this is a database
        List<Item> itemDB = new List<Item>()
        {
            new Item("Monitor", 100.00m),
            new Item("Keyboard", 65.99m),
            new Item("Mouse", 40.99m),
            new Item("Headset", 199.99m)
        };

        public void ItemAction(Item i)
        {
            ItemView view = new ItemView(i);
            view.Display();
        }

        public void WelcomeAction()
        {
            foreach(Item i in itemDB)
            {
                ItemAction(i);
            }
        }


    }
}

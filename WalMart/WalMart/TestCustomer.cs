using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalMart.Astar;

namespace WalMart
{
    class TestCustomer
    {
        CustomList<string> list = new CustomList<string>();
        ShoppingList shoplist = new ShoppingList();

        public TestCustomer()
        {
            getItems();
        }
        public CustomList<string> getItems()
        {
            if(list.Count() != null)
            {
                Random rand = new Random(500);

                int temp = rand.Next(1, 7);
                int temp2 = Convert.ToInt32(list.Count());
                while (temp2 < temp)
                {
                    string tempnr = Convert.ToString(rand.Next(1, 21));
                    // get tempitem = ShoppingList array item

                    //string tempItem = shoplist.Array[tempnr]
                   // if (!list.Contains(tempitem))
                  //  {
                    //    list.addItem(tempitem);
                    //}
                }

                return list;
            }
            else
            {
                return list;
            }
        }
    }
}

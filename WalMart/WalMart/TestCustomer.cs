using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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
        public ShoppingList shoplist = new ShoppingList();
        List<string> test = new List<string>();
        public SpriteFont font;
        float positionX = 1900;
        float positionY = 700;

        public TestCustomer()
        {
            getItems();
        }
        public CustomList<string> getItems()
        {
            if(list.Count() != null)
            {
                Random rand = new Random();

                int temp = rand.Next(1, 7);
                string tempstring = Convert.ToString(temp);
                int temp2 = list.CountTotal();
                while (temp2 < temp)
                {
                    int tempnr = rand.Next(1, 21);
                    // get tempitem = ShoppingList array item

                    string tempItem = shoplist.items[tempnr];
                    if (!list.Contains(tempItem))
                    {
                        list.addItem(tempItem);
                    }
                    temp2 = list.CountTotal();
                }

                

                return list;
            }
            else
            {
                return list;
            }
        }

        public void Draw(SpriteBatch batch)
        {
            foreach (var item in list.Count())
            {
                for (int i = 0; i < item.Length; i++)
                {
                   
                    batch.DrawString(font, item, new Vector2(positionX, positionY), Color.White);
                    

                }
            }
        }
    }
}

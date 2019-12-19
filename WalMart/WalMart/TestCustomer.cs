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
        //float positionX = 1900;
        //float positionY = 700;
       

        public TestCustomer()
        {
            getItems();
           
        }
        public CustomList<string> getItems()
        {
            if (list.Count() != null)
            {
                Random rand = new Random();
                int temp = list.CountTotal();
                while (temp < 7)
                {
                    int tempnr = rand.Next(1, 21);
                    // get tempitem = ShoppingList array item

                    string tempItem = shoplist.items[tempnr];
                    if (!list.Contains(tempItem))
                    {
                        list.addItem(tempItem);
                    }
                    temp = list.CountTotal();
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
            Vector2 pos = new Vector2(1750, 650);
            foreach (var item in list.Count())
            {


                batch.DrawString(font, item, pos, Color.Black);
                pos += new Vector2(0, 20);


            }
        }
    }
}

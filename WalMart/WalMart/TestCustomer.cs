using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WalMart.Astar;

namespace WalMart
{
    class TestCustomer
    {
        CustomList<string> list = new CustomList<string>();
    //    CustomList<Vector2> pos = new CustomList<Vector2>();
        public ShoppingList shoplist = new ShoppingList();
   //    public Vector2[] posArray;


        public SpriteFont font;
       
        public TestCustomer(float positionX, float positionY)
        {
            //this.positionX = positionX;
            //this.positionY = positionY;
            getItems();
        }
        public CustomList<string> getItems()
        {
            if(list.Count() != null)
            {
                Random rand = new Random();

             //   posArray = new Vector2[temp];
                int temp2 = list.CountTotal();
                while (temp2 < 7)
                {
                  
                    int tempnr = rand.Next(1, 21);
                    // get tempitem = ShoppingList array item

                    string tempItem = shoplist.items[tempnr];
                //    Vector2 tempLocation = shoplist.itemPosition[tempnr];
                    if (!list.Contains(tempItem))
                    {
                        list.addItem(tempItem);
                 //       pos.addItem(tempLocation);

                    }
                    temp2 = list.CountTotal();
                }
            //    posArray = pos.ToArray();
                return list;
            }
            else
            {
                return list;
            }

        }

        public void findPath()
        {

            //foreach (Vector2 itemPos in posArray)
            //{
                
            //    for (int i = 0; i < Level.gridwidth; i++)
            //    {
            //        for (int j = 0; j < Level.gridHeight; j++)
            //        {

            //            if (Level.grid[i,j] == itemPos[itemPos.X,itemPos.Y])
            //            {

            //                Pathfinder path1 = new Pathfinder(Level.grid);
            //                path1.SearchPath(new Vector2(23, 4), itemPos);
            //            }
            //        }
            //    }


            //}
        }

        public void Draw(SpriteBatch batch)
        {
            foreach (var item in list.Count())
            {
                float positionX = 1900;
                float positionY = 700;

                for (int i = 0; i < item.Length; i++)
                {                 
                    batch.DrawString(font, item, new Vector2(positionX, positionY), Color.White);

                    positionY += 20; 
                }
            }
        }
    }
}

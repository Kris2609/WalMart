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
        Vector2 startPos = new Vector2(23,4);
        Vector2 currentTile = new Vector2(23, 4);

        public SpriteFont font;
        float positionX;
        float positionY;

        float statPosX;
        float statPosY;
        bool shopping = true;
        public TestCustomer(float positionX, float positionY)
        {
            this.positionX = positionX;
            statPosX = positionX;
            this.positionY = positionY;
            statPosY = positionY;
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
            //currentTile = startPos;

            //foreach (var itemPos in list.Count())
            //{
            //    #region If statesment

            //    if (itemPos == "screwDriver")
            //    {
            //        Pathfinder path3 = new Pathfinder(Level.grid);
            //        path3.SearchPath(currentTile, new Vector2(12, 1));

            //        currentTile = new Vector2(12, 1);
            //    }
            //    else if (itemPos == "apple")
            //    {
            //        Pathfinder path4 = new Pathfinder(Level.grid);
            //        path4.SearchPath(currentTile, new Vector2(5, 5));

            //        currentTile = new Vector2(5, 5);
            //    }
            //    else if (itemPos == "banana")
            //    {
            //        Pathfinder path5 = new Pathfinder(Level.grid);
            //        path5.SearchPath(currentTile, new Vector2(5, 6));

            //        currentTile = new Vector2(5, 6);
            //    }
            //    else if (itemPos == "burrito")
            //    {
            //        Pathfinder path6 = new Pathfinder(Level.grid);
            //        path6.SearchPath(currentTile, new Vector2(5, 7));

            //        currentTile = new Vector2(5, 7);
            //    }
            //    else if (itemPos == "coffee")
            //    {
            //        Pathfinder path7 = new Pathfinder(Level.grid);
            //        path7.SearchPath(currentTile, new Vector2(5, 8));

            //        currentTile = new Vector2(5, 8);
            //    }
            //    else if (itemPos == "computer")
            //    {
            //        Pathfinder path8 = new Pathfinder(Level.grid);
            //        path8.SearchPath(currentTile, new Vector2(15, 8));

            //        currentTile = new Vector2(15, 8);
            //    }
            //    else if (itemPos == "gold")
            //    {
            //        Pathfinder path9 = new Pathfinder(Level.grid);
            //        path9.SearchPath(currentTile, new Vector2(15, 5));

            //        currentTile = new Vector2(15, 5);
            //    }
            //    else if (itemPos == "golf")
            //    {
            //        Pathfinder path10 = new Pathfinder(Level.grid);
            //        path10.SearchPath(currentTile, new Vector2(15, 7));

            //        currentTile = new Vector2(15, 7);
            //    }
            //    else if (itemPos == "granateLuncher")
            //    {
            //        Pathfinder path11 = new Pathfinder(Level.grid);
            //        path11.SearchPath(currentTile, new Vector2(8, 1));

            //        currentTile = new Vector2(8, 1);
            //    }
            //    else if (itemPos == "hammer")
            //    {
            //        Pathfinder path12 = new Pathfinder(Level.grid);
            //        path12.SearchPath(currentTile, new Vector2(11, 1));

            //        currentTile = new Vector2(11, 1);
            //    }
            //    else if (itemPos == "measureTape")
            //    {
            //        Pathfinder path13 = new Pathfinder(Level.grid);
            //        path13.SearchPath(currentTile, new Vector2(10, 1));

            //        currentTile = new Vector2(10, 1);
            //    }
            //    else if (itemPos == "shovel")
            //    {
            //        Pathfinder path14 = new Pathfinder(Level.grid);
            //        path14.SearchPath(currentTile, new Vector2(9, 1));

            //        currentTile = new Vector2(9, 1);
            //    }
            //    else if (itemPos == "nailPolish")
            //    {
            //        Pathfinder path15 = new Pathfinder(Level.grid);
            //        path15.SearchPath(currentTile, new Vector2(10, 9));

            //        currentTile = new Vector2(10, 9);
            //    }
            //    else if (itemPos == "pear")
            //    {
            //        Pathfinder path16 = new Pathfinder(Level.grid);
            //        path16.SearchPath(currentTile, new Vector2(5, 9));

            //        currentTile = new Vector2(5, 9);
            //    }
            //    else if (itemPos == "perfume")
            //    {
            //        Pathfinder path17 = new Pathfinder(Level.grid);
            //        path17.SearchPath(currentTile, new Vector2(10, 8));

            //        currentTile = new Vector2(10, 8);
            //    }
            //    else if (itemPos == "watch")
            //    {
            //        Pathfinder path18 = new Pathfinder(Level.grid);
            //        path18.SearchPath(currentTile, new Vector2(15, 6));

            //        currentTile = new Vector2(15, 6);
            //    }
            //    else if (itemPos == "scrum")
            //    {
            //        Pathfinder path19 = new Pathfinder(Level.grid);
            //        path19.SearchPath(currentTile, new Vector2(5, 5));

            //        currentTile = new Vector2(5, 5);
            //    }
            //    else if (itemPos == "toiletPaper")
            //    {
            //        Pathfinder path20 = new Pathfinder(Level.grid);
            //        path20.SearchPath(currentTile, new Vector2(10, 5));

            //        currentTile = new Vector2(10, 5);
            //    }
            //    else if (itemPos == "toothPaste")
            //    {
            //        Pathfinder path21 = new Pathfinder(Level.grid);
            //        path21.SearchPath(currentTile, new Vector2(10, 7));

            //        currentTile = new Vector2(10, 7);
            //    }
            //    else if (itemPos == "towel")
            //    {
            //        Pathfinder path22 = new Pathfinder(Level.grid);
            //        path22.SearchPath(currentTile, new Vector2(10, 6));

            //        currentTile = new Vector2(10, 6);
            //    }
            //    else if (itemPos == "tv")
            //    {
            //        Pathfinder path23 = new Pathfinder(Level.grid);
            //        path23.SearchPath(currentTile, new Vector2(15, 9));

            //        currentTile = new Vector2(15, 9);
            //    }
            //    #endregion

            //}
            //Pathfinder end = new Pathfinder(Level.grid);
            //    end.SearchPath(currentTile, new Vector2(23, 9));


            
        }

        public void Draw(SpriteBatch batch)
        {
            
            foreach (var item in list.Count())
            {
                
                    batch.DrawString(font, item, new Vector2(positionX, positionY), Color.White);
                    positionY += 20; 
                
               
            }
            
            positionX = statPosX;

            positionY = statPosY;
        }
    }
}

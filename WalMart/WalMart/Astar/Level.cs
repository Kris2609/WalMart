using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalMart.Astar
{
   public static class Level
    {
        public static int gridwidth = 24; 
        public static int gridHeight = 14; 
        public static Texture2D TileBlock;
        public static Texture2D apple;
        public static Texture2D gold;
        public static Texture2D tv;
        public static Texture2D hammer;
        public static Texture2D nailPolish;
        public static Tile[,] grid = new Tile[gridwidth, gridHeight];
        static Random  rand = new Random(520);

        static Level()
        {
            
        }
        public static void GetTexture(Texture2D texture)
        {
            Level.TileBlock = texture;
            Level.apple = ShoppingList.apple;
            Level.gold = ShoppingList.gold;
            Level.tv = ShoppingList.tv;
            Level.nailPolish = ShoppingList.nailPolish;

        }
        public static void Draw(SpriteBatch batch)
        {

            for (int i = 0; i < gridwidth; i++)
            {
                for (int j = 0; j < gridHeight; j++)
                {
                    if (i == 5 && j > 4 && j < 11) //walkeable false
                    {
                        //make a new tile

                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(apple, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if (i == 10 && j > 4 && j < 11)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(gold, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                   
                    else if (i == 15 && j > 4 && j < 11)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(tv, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if (i > 4 && i < 16 && j == 1)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(tv, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if (i > 4 && i < 16 && j == 13)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(nailPolish, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if(i == 23 && j == 4) //Start Tile
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, true);
                        batch.Draw(TileBlock, new Rectangle(i * 70, j * 70, 70, 70), Color.Green);
                    }
                    else if (i == 23 && j == 9) //goal Tile
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, true);
                        batch.Draw(TileBlock, new Rectangle(i * 70, j * 70, 70, 70), Color.Blue);
                    }
                    else if (i == 1 && j == 9) //item Tile
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, true);
                        batch.Draw(TileBlock, new Rectangle(i * 70, j * 70, 70, 70), Color.Yellow);
                    }
                    else
                    {
                        //make a new tile

                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, true);
                        batch.Draw(TileBlock, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                   
                }
            }
            //make a new pathfinder
            Pathfinder path1 = new Pathfinder(grid);
            path1.SearchPath(new Vector2(23, 4), new Vector2(1, 9));
            path1.Draw(batch);

            Pathfinder path2 = new Pathfinder(grid);
            path2.SearchPath(new Vector2(1, 9), new Vector2(23, 9));
            path2.Draw(batch);




        }

        
    }
}

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
        public static int gridwidth = 25;
        public static int gridHeight = 25;
        public static Texture2D TileBlock;
        public static Tile[,] grid = new Tile[gridwidth, gridHeight];
        static Random  rand = new Random(520);

        static Level()
        {
            
        }
        public static void GetTexture(Texture2D texture)
        {
            Level.TileBlock = texture;
        }
        public static void Draw(SpriteBatch batch)
        {

            for (int i = 0; i < gridwidth; i++)
            {
                for (int j = 0; j < gridHeight; j++)
                {
                    if (i == 5 && j > 5 && j < 20) //walkeable false
                    {
                        //make a new tile

                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(TileBlock, new Rectangle(i * 32, j * 32, 32, 32), Color.Black);
                    }
                    else if (i == 9 && j > 5 && j < 20)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(TileBlock, new Rectangle(i * 32, j * 32, 32, 32), Color.Black);
                    }
                    else if (i == 14 && j > 5 && j < 20)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(TileBlock, new Rectangle(i * 32, j * 32, 32, 32), Color.Black);
                    }
                    else if (i == 18 && j > 5 && j < 20)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(TileBlock, new Rectangle(i * 32, j * 32, 32, 32), Color.Black);
                    }
                    else if (i > 4 && i < 19 && j == 2)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(TileBlock, new Rectangle(i * 32, j * 32, 32, 32), Color.Black);
                    }
                    else if (i > 4 && i < 19 && j == 23)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(TileBlock, new Rectangle(i * 32, j * 32, 32, 32), Color.Black);
                    }
                    else if(i == 1 && j == 12) //Start Tile
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, true);
                        batch.Draw(TileBlock, new Rectangle(i * 32, j * 32, 32, 32), Color.Green);
                    }
                    else if (i == 23 && j == 12) //goal Tile
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, true);
                        batch.Draw(TileBlock, new Rectangle(i * 32, j * 32, 32, 32), Color.Blue);
                    }
                    else
                    {
                        //make a new tile

                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, true);
                        batch.Draw(TileBlock, new Rectangle(i * 32, j * 32, 32, 32), Color.White);
                    }
                   
                }
            }
            //make a new pathfinder
            Pathfinder path1 = new Pathfinder(grid);
            path1.SearchPath(new Vector2(1, 12), new Vector2(23, 12));
            path1.Draw(batch);

            Pathfinder path2 = new Pathfinder(grid);
            path2.SearchPath(new Vector2(3, 1), new Vector2(20, 23));
            path2.Draw(batch);

        }

        
    }
}

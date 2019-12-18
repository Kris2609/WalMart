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
        public static Texture2D banana;
        public static Texture2D pear;
        public static Texture2D burrito;
        public static Texture2D coffee;
        public static Texture2D hammer;
        public static Texture2D measureTape;
        public static Texture2D shovel;
        public static Texture2D screwDriver;
        public static Texture2D gold;
        public static Texture2D scrum;
        public static Texture2D nailPolish;
        public static Texture2D perfume;
        public static Texture2D toiletPaper;
        public static Texture2D toothPaste;
        public static Texture2D towel;
        public static Texture2D tv;
        public static Texture2D computer;
        public static Texture2D granateLuncher;
        public static Texture2D watch;
        public static Texture2D golf;
        public static Tile[,] grid = new Tile[gridwidth, gridHeight];
        static Random  rand = new Random(520);

        static Level()
        {
            
        }
        public static void GetTexture(Texture2D texture)
        {
            Level.TileBlock = texture;
            Level.apple = ShoppingList.apple;
            Level.banana = ShoppingList.banana;
            Level.burrito = ShoppingList.burrito;
            Level.pear = ShoppingList.pear;
            Level.coffee = ShoppingList.coffee;
            Level.gold = ShoppingList.gold;
            Level.tv = ShoppingList.tv;
            Level.scrum = ShoppingList.scrum;
            Level.nailPolish = ShoppingList.nailPolish;
            Level.perfume = ShoppingList.perfume;
            Level.computer = ShoppingList.computer;
            Level.towel = ShoppingList.towel;
            Level.toiletPaper = ShoppingList.toiletPaper;
            Level.toothPaste = ShoppingList.toothPaste;
            Level.measureTape = ShoppingList.measureTape;
            Level.shovel = ShoppingList.shovel;
            Level.screwDriver = ShoppingList.screwDriver;
            Level.watch = ShoppingList.watch;
            Level.granateLuncher = ShoppingList.granateLuncher;
            Level.golf = ShoppingList.golf;
            Level.hammer = ShoppingList.hammer;
        
        Level.nailPolish = ShoppingList.nailPolish;

        }
        public static void Draw(SpriteBatch batch)
        {

            for (int i = 0; i < gridwidth; i++)
            {
                for (int j = 0; j < gridHeight; j++)
                {
                    if (i == 5 && j == 5) //walkeable false
                    {
                        //make a new tile

                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(apple, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if (i == 5 && j == 6) //walkeable false
                    {
                        //make a new tile

                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(banana, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if (i == 5 && j == 7) //walkeable false
                    {
                        //make a new tile

                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(burrito, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if (i == 5 && j == 8) //walkeable false
                    {
                        //make a new tile

                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(coffee, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if (i == 5 && j == 9) //walkeable false
                    {
                        //make a new tile

                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(pear, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if (i == 10 && j == 5)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(toiletPaper, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if (i == 10 && j == 6)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(towel, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if (i == 10 && j == 7)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(toothPaste, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if (i == 10 && j == 8)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(perfume, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if (i == 10 && j == 9)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(nailPolish, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if (i == 15 && j == 5)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(gold, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if (i == 15 && j == 6)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(watch, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if (i == 15 && j == 7)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(golf, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if (i == 15 && j == 8)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(computer, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if (i == 15 && j == 9)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(tv, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if (i == 8 && j == 1)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(granateLuncher, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if (i == 9 && j == 1)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(shovel, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if (i == 10 && j == 1)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(measureTape, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if (i == 11 && j == 1)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(hammer, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if (i == 12 && j == 1)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(screwDriver, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if (i == 8 && j == 13)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(TileBlock, new Rectangle(i * 70, j * 70, 70, 70), Color.Black);
                    }
                    else if (i == 9 && j == 13)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(TileBlock, new Rectangle(i * 70, j * 70, 70, 70), Color.Black);
                    }
                    else if (i == 10 && j == 13)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(TileBlock, new Rectangle(i * 70, j * 70, 70, 70), Color.Black);
                    }
                    else if (i == 11 && j == 13)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(TileBlock, new Rectangle(i * 70, j * 70, 70, 70), Color.Black);
                    }
                    else if (i == 12 && j == 13)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(TileBlock, new Rectangle(i * 70, j * 70, 70, 70), Color.Black);
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

           




        }

        
    }
}

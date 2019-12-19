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
        public static void GetTexture(Texture2D texture, Texture2D computer, Texture2D screwDriver, Texture2D shovel, Texture2D watch, Texture2D measureTape, Texture2D perfume, Texture2D toiletPaper, Texture2D toothPaste, Texture2D hammer, Texture2D apple, Texture2D banana, Texture2D burrito, Texture2D pear, Texture2D coffee, Texture2D gold, Texture2D tv, Texture2D scrum, Texture2D nailPolish, Texture2D golf, Texture2D granateLuncher, Texture2D towel)
        {
            Level.TileBlock = texture;
            Level.apple = apple;
            Level.banana = banana;
            Level.burrito = burrito;
            Level.pear = pear;
            Level.coffee = coffee;
            Level.gold = gold;
            Level.tv = tv;
            Level.scrum = scrum;
            Level.nailPolish = nailPolish;
            Level.perfume = perfume;
            Level.computer = computer;
            Level.towel = towel;
            Level.toiletPaper = toiletPaper;
            Level.toothPaste = toothPaste;
            Level.measureTape = measureTape;
            Level.shovel = shovel;
            Level.screwDriver = screwDriver;
            Level.watch = watch;
            Level.granateLuncher = granateLuncher;
            Level.golf = golf;
            Level.hammer = hammer;
            
        }
        public static void Draw(SpriteBatch batch)
        {

            for (int i = 0; i < gridwidth; i++)
            {
                for (int j = 0; j < gridHeight; j++)
                {
                    #region Items
                    if (i == 5 && j == 5) //walkeable false
                    {
                        //make a new tile

                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, true);
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
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, true);
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
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, true);
                        batch.Draw(shovel, new Rectangle(i * 70, j * 70, 70, 70), Color.White);
                    }
                    else if (i == 10 && j == 1)
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, true);
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
                    #endregion
                    #region Start, End and Item Tile

                    else if (i == 23 && j == 4) //Start Tile
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, true);
                        batch.Draw(TileBlock, new Rectangle(i * 70, j * 70, 70, 70), Color.Green);
                    }
                    else if (i == 23 && j == 9) //goal Tile
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, true);
                        batch.Draw(TileBlock, new Rectangle(i * 70, j * 70, 70, 70), Color.Blue);
                    }
                    else if (i == 10 && j == 9) //item Tile
                    {
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, true); 
                        batch.Draw(TileBlock, new Rectangle(i * 70, j * 70, 70, 70), Color.Yellow);
                    }
                    #endregion
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
            path1.SearchPath(new Vector2(23, 4), new Vector2(10, 11));
            path1.Draw(batch);

            Pathfinder path2 = new Pathfinder(grid);
            path2.SearchPath(new Vector2(10, 11), new Vector2(5, 5));
            path2.Draw(batch);
            Pathfinder path3 = new Pathfinder(grid);
            path3.SearchPath(new Vector2(5,5), new Vector2(9, 1));
            path3.Draw(batch);
            Pathfinder path4 = new Pathfinder(grid);
            path4.SearchPath(new Vector2(9,1),new Vector2(10, 1));
            path4.Draw(batch);
            Pathfinder path5 = new Pathfinder(grid);
            path5.SearchPath(new Vector2(10, 1), new Vector2(15, 8));
            path5.Draw(batch);
            Pathfinder path6 = new Pathfinder(grid);
            path6.SearchPath(new Vector2(15, 8), new Vector2(23, 9));
            path6.Draw(batch);
            
        }
    }
}

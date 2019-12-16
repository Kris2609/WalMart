using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalMart.Astar
{
   public class Level
    {
        public static int gridwidth = 10;
        public static int gridHeight = 10;
        public Texture2D TileBlock;
        public Tile[,] grid = new Tile[gridwidth, gridHeight];
        Random rand = new Random(520);

        public Level()
        {
            
        }
        public void GetTexture(Texture2D texture)
        {
            this.TileBlock = texture;
        }
        public void Draw(SpriteBatch batch)
        {

            for (int i = 0; i < gridwidth; i++)
            {
                for (int j = 0; j < gridHeight; j++)
                {
                    if(rand.Next(0, 100) < 10) //walkeable false
                    {
                        //make a new tile
                        grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, false);
                        batch.Draw(TileBlock, new Rectangle(i * 32, j * 32, 32, 32), Color.Black);
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
            path1.SearchPath(new Vector2(0, 0), new Vector2(9, 9));
            
        }

        
    }
}

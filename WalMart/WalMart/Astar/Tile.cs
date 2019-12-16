using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalMart.Astar
{
    public class Tile
    {
        private Texture2D tileBlock;
        public Vector2 ID;
        public Vector2 position;
        public int cost = 0;
        public int heuristic = 0;
        public int total = 0;
        public bool walkable;

        public Tile(Vector2 ID, Vector2 position, Texture2D tileBlock, bool walkable)
        {
            this.ID = ID;
            this.position = position;
            this.tileBlock = tileBlock;
            this.walkable = walkable;

            if (!this.walkable)
            {
                //change color
            }
            else
            {
                //do nothing
            }
        }
        
    }
}

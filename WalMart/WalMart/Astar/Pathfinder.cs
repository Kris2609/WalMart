using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalMart.Astar
{
    public class Pathfinder
    {
        public static Texture2D TileBlock;
        public Tile[,] grid = new Tile[Level.gridwidth, Level.gridHeight];
        public Vector2 startTile = new Vector2(0, 0);
        public Vector2 goal;
        public Vector2 currentTile;
        
        CustomList<Vector2> pathTiles = new CustomList<Vector2>();

        //create the lists that stores allready checked tiles
        CustomList<Vector2> closedList = new CustomList<Vector2>();
        CustomList<Vector2> openList = new CustomList<Vector2>();

        public Pathfinder(Tile[,] grid)
        {
            this.grid = grid;
            
        }

        #region A* pseudo  "from Youtube user Jorn Theunissen" Brugt som inspration
        ////////////////////////////////////////////////////////////////////////
        ///add the starting node to open list
        ///while the opeb list is not empty
        ///{
        /// current node = node from open list whit lowest cost
        /// if currentnode = goal
        ///     path complete
        /// else
        ///     move current node to closed list
        ///     for each adjacent node
        ///         if it lies whit the field
        ///             and it isent an obstacle
        ///                 and it isent on the open list
        ///                     and it isent on the closed list
        ///                         move to the open list and calculate cost
        //////////////////////////////////////////////////////////////////////

        #endregion

        public void SearchPath(Vector2 startTile, Vector2 goal)
        {
            this.startTile = startTile;
            this.goal = goal;

            #region Path Validation
            bool canSearch = true;

            if (grid[(int)startTile.X,(int)startTile.Y].walkable == false)
            {
                Console.WriteLine("The start tile is non walkable. Chose a diffrent value than: " + startTile.ToString());
                canSearch = false;
            }
            if (grid[(int)goal.X,(int)goal.Y].walkable == false)
            {
                Console.WriteLine("The goal is non walkable. Chose a diffrent value than: " + goal.ToString());
                canSearch = false;
            }
            #endregion

            //start the A* algorithm
            if (canSearch)
            {
                //add the starting tile to open list
                
                openList.addItem(startTile);
                currentTile = new Vector2(-1, -1);

                //while openlist not empty

            while(openList.Count() != null)
                {
                    currentTile = GetTileWhitLowestTotal(openList);

                    //check if we reached the goal and stop search
                    if(currentTile.X == goal.X && currentTile.Y == goal.Y)
                    {
                        Console.WriteLine("found goal tile");
                        break;
                    }
                    else
                    {
                        //move current tile to clost list and remove it from the open list
                        openList.removeItem(currentTile);
                        closedList.addItem(currentTile);

                        //get all adjacentTiles
                        CustomList<Vector2> adjacentTiles = GetAdjacentTiles(currentTile);

                        foreach (Vector2 adjacentTile in adjacentTiles.Count())
                        {
                            //adjacent tile can not be in open list
                            if (!openList.Contains(adjacentTile))
                            {
                                //adjacent tile can not be in closed list
                                if (!closedList.Contains(adjacentTile))
                                {
                                    //move to the open list and calculate cost
                                    openList.addItem(adjacentTile);

                                    Tile tile = grid[(int)adjacentTile.X, (int)adjacentTile.Y];

                                    //Calculate the cost
                                    tile.cost = grid[(int)currentTile.X, (int)currentTile.Y].cost + 1;

                                    //Calculate the manhatten distance
                                    tile.heuristic = ManhattanDistance(adjacentTile);

                                    //calculate the total amount
                                    tile.total = tile.cost + tile.heuristic;

                                    //make tile green (for testing)

                                }
                            }
                           
                        }

                    }
                }
            }
            //Make start and goal tile red (for testing)

            //show the path
            ShowPath();
        }
        public void ShowPath()
        {
            bool startFound = false;

            Vector2 currentTile = goal;
           
            while (startFound == false)
            {
                CustomList<Vector2> adjacentTiles = GetAdjacentTiles(currentTile);

                //Check to see what newest current tile
                foreach (Vector2 adjacentTile in adjacentTiles.Count())
                {
                    //Check if it is the start tile
                    if(adjacentTile.X == startTile.X && adjacentTile.Y == startTile.Y)
                    {
                        startFound = true;
                        break;
                    }
                    // it has to be inside the closed as well as the inside the open list
                    if (closedList.Contains(adjacentTile) || openList.Contains(adjacentTile))
                    {
                        if (grid[(int)adjacentTile.X, (int)adjacentTile.Y].cost <= grid[(int)currentTile.X, (int)currentTile.Y].cost
                            && grid[(int)adjacentTile.X, (int)adjacentTile.Y].cost > 0)
                        {
                            //change the current Tile
                            currentTile = adjacentTile;

                            //add this adjacent tile to the path list
                            pathTiles.addItem(adjacentTile);

                            //Change colors for final path (for testing)
                        }
                    }
                }
               
            }
        }
        //get the tile whit lowest value
        public Vector2 GetTileWhitLowestTotal(CustomList<Vector2> openList)
        {
            //temp variables
            Vector2 tileWithLowestTotal = new Vector2(-1, -1);
            int lowestTotal = int.MaxValue;

            //search all the open tiles and get tile with lowest cost
            foreach (Vector2 openTile in openList.Count())
            {
                if(grid[(int)openTile.X,(int)openTile.Y].total <= lowestTotal)
                {
                    lowestTotal = grid[(int)openTile.X,(int)openTile.Y].total;
                    tileWithLowestTotal = new Vector2((int)openTile.X,(int)openTile.Y);
                }
            }
            return tileWithLowestTotal;
        }
        //check if it is in the boundry and if its walkable
        public CustomList<Vector2> GetAdjacentTiles(Vector2 currentTile)
        {
            CustomList<Vector2> adjacentTiles = new CustomList<Vector2>();
            Vector2 adjacentTile;

            //Tile above
            adjacentTile = new Vector2(currentTile.X, currentTile.Y + 1);
            if(adjacentTile.Y < Level.gridHeight && grid[(int)adjacentTile.X, (int)adjacentTile.Y].walkable)
            {
                adjacentTiles.addItem(adjacentTile);
            }
            //Tile underneath
            adjacentTile = new Vector2(currentTile.X, currentTile.Y - 1);
            if (adjacentTile.Y >= 0 && grid[(int)adjacentTile.X, (int)adjacentTile.Y].walkable)
            {
                adjacentTiles.addItem(adjacentTile);
            }
            //Tile to the right
            adjacentTile = new Vector2(currentTile.X + 1, currentTile.Y);
            if (adjacentTile.X < Level.gridwidth && grid[(int)adjacentTile.X, (int)adjacentTile.Y].walkable)
            {
                adjacentTiles.addItem(adjacentTile);
            }
            //Tile to the left
            adjacentTile = new Vector2(currentTile.X - 1, currentTile.Y);
            if (adjacentTile.X >= 0 && grid[(int)adjacentTile.X, (int)adjacentTile.Y].walkable)
            {
                adjacentTiles.addItem(adjacentTile);
            }

            //DIAGONAL CHECKING

            return adjacentTiles;
        }

        //calculate the manhatten disctance
        public int ManhattanDistance(Vector2 adjacentTile)
        {
            int manhatten = Math.Abs((int)(goal.X - adjacentTile.X)) + Math.Abs((int)(goal.Y - adjacentTile.Y));

            return manhatten;
        }
        public static void GetTexture(Texture2D texture)
        {
            TileBlock = texture;
        }
        public void Draw(SpriteBatch batch)
        {
            foreach (Vector2 pathlist in pathTiles.Count())
            {
                for (int i = 0; i < Level.gridwidth; i++)
                {
                    for (int j = 0; j < Level.gridHeight; j++)
                    {
                        if (grid[(int)pathlist.X, (int)pathlist.Y] == grid[i,j])
                        {
                            grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, true);
                            batch.Draw(TileBlock, new Rectangle(i * 70, j * 70, 70, 70), Color.Blue);
                        }
                    }
                }
            }
            foreach (Vector2 openlist in openList.Count())
            {
                for (int i = 0; i < Level.gridwidth; i++)
                {
                    for (int j = 0; j < Level.gridHeight; j++)
                    {
                        if (grid[(int)openlist.X, (int)openlist.Y] == grid[i, j])
                        {
                            grid[i, j] = new Tile(new Vector2(i, j), new Vector2(i * 1.8f, j * 1.8f), TileBlock, true);
                            batch.Draw(TileBlock, new Rectangle(i * 70, j * 70, 70, 70), Color.Brown);
                        }
                    }
                }
            }
        }
    }
}

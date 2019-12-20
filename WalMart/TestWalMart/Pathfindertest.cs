﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xna.Framework;
using WalMart.Astar;

namespace TestWalMart
{
    [TestClass]
    public class Pathfindertest
    {
        private Tile[,] grid = new Tile[Level.gridwidth,Level.gridHeight]; 

        private Vector2 startTile;
        private Vector2 goal;
        [TestMethod]

        public void TestInstantiatePathFinder()
        {
            Pathfinder pf = new Pathfinder(grid);
            Assert.IsInstanceOfType(pf, typeof(Pathfinder));
        }
        [TestMethod]
        public void SearchPathtest()
        {
        }
        [TestMethod]
        public void ShowPathtest()
        {
            Pathfinder pf = new Pathfinder(grid);
            
            startTile = new Vector2(2, 2);
            goal = new Vector2(5, 5);
            pf.openList.addItem(startTile);
            pf.openList.addItem(goal);
            
            Assert.AreNotEqual(startTile, goal);

        }
        [TestMethod]
        public void GetTileWhitLowestTotaltest()
        {

        }
        [TestMethod]
        public void GetAdjacentTilestest()
        {

        }
        [TestMethod]
        public void ManhattanDistancetest()
        {

        }
        [TestMethod]
        public void Drawtest()
        {

        }

    }
}

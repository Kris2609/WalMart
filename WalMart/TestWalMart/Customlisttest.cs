using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WalMart.Astar;

namespace TestWalMart
{
    [TestClass]
    public class Customlisttest
    {
        [TestMethod]
        public void addTeam()
        {
            //Arrange
            CustomList<int> listtest = new CustomList<int>();
            int value1 = 7;
            int value2 = 4;
            int expected = 2;
            //Act
            listtest.addItem(value1);
            listtest.addItem(value2);

            int actualy = listtest.CountTotal();
            //Assert
            Assert.AreEqual(expected, actualy);
        }

        [TestMethod]
        public void removeTeam()
        {
            CustomList<int> listtest = new CustomList<int>();
            int value1 = 7;
            int value2 = 4;
            int expected = 1;
            //Act
            listtest.addItem(value1);
            listtest.addItem(value2);

            listtest.removeItem(value2);

            int actualy = listtest.CountTotal();
            //Assert
            Assert.AreEqual(expected, actualy);

        }
        [TestMethod]
        public void CountTest()
        {
            //Arrange
            CustomList<int> listtest = new CustomList<int>();
            int value1 = 7;
            int value2 = 4;
            bool expected = true;
            bool actualy = false;
            //Act
            listtest.addItem(value1);
            listtest.addItem(value2);
            foreach (int item in listtest.Count())
            {
                if (item == 7 || item == 4)
                {
                    actualy = true;
                }
            }

            
            //Assert
            Assert.AreEqual(expected, actualy);
        }
        [TestMethod]
        public void CountTotalTest()
        {
            //Arrange
            CustomList<int> listtest = new CustomList<int>();
            int value1 = 7;
            int value2 = 4;
            int expected = 6;
            //Act
            listtest.addItem(value1);
            listtest.addItem(value2);
            listtest.addItem(value1);
            listtest.addItem(value2);
            listtest.addItem(value1);
            listtest.addItem(value2);

            int actualy = listtest.CountTotal();
            //Assert
            Assert.AreEqual(expected, actualy);
        }
       

    }
}

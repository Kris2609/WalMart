using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalMart
{

    public class ShoppingList
    {
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

        public Texture2D ListBlack;
        public Texture2D ListGreen;
        public Texture2D ListBlue; 


        public static void SortItems()
        {
            Object[] list = new Object[5];
            Random rnd = new Random();
            ShoppingList[] items = new ShoppingList[21];

            foreach (ShoppingList item in items)
            {
                for (int i = 0; i <= 5; i++)
                {

                    list[0] = rnd.Next(0, items.Length);
                    list[1] = rnd.Next(0, items.Length);
                    list[2] = rnd.Next(0, items.Length);
                    list[3] = rnd.Next(0, items.Length);
                    list[4] = rnd.Next(0, items.Length);

                }
            }
        }
    }
}





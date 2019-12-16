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
        public Texture2D apple; 
        public Texture2D banana;
        public Texture2D pear;
        public Texture2D burrito;
        public Texture2D coffee;
        public Texture2D hammer;
        public Texture2D measureTape;
        public Texture2D shovel;
        public Texture2D screwDriver;
        public Texture2D gold;
        public Texture2D scrum;
        public Texture2D nailPolish;
        public Texture2D perfume;
        public Texture2D toiletPaper;
        public Texture2D toothPaste;
        public Texture2D towel;
        public Texture2D tv;
        public Texture2D computer;
        public Texture2D granateLuncher;
        public Texture2D watch;
        public Texture2D golf;



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





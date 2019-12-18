﻿using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalMart.Astar;
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

        public Texture2D ListBlack;
        public Texture2D ListGreen;
        public Texture2D ListBlue;

        public string[] items = new string[21];

        public ShoppingList()
        {
            items[0] = screwDriver + "screwDriver";
            items[1] = apple + "apple";
            items[2] = banana + "banana";
            items[3] = burrito + "burrito";
            items[4] = coffee + "coffee";
            items[5] = computer + "computer";
            items[6] = gold + "gold";
            items[7] = golf + "golf";
            items[8] = granateLuncher + "granateLuncher";
            items[9] = hammer + "hammer";
            items[10] = measureTape + "measureTape";
            items[11] = shovel + "shovel";
            items[12] = nailPolish + "nailPolish";
            items[13] = pear + "pear";
            items[14] = perfume + "perfume";
            items[15] = watch + "watch";
            items[16] = scrum + "scrum";
            items[17] = toiletPaper + "toiletPaper";
            items[18] = toothPaste + "toothPaste";
            items[19] = towel + "towel";
            items[20] = tv + "tv";
        }
        //public void GetTexture(Texture2D sdTexture, Texture2D textureap, Texture2D textureba, Texture2D texturebu, Texture2D textureco,
        //    Texture2D texturecom, Texture2D texturegold, Texture2D texturegolf, Texture2D texturegra, Texture2D textureham, Texture2D texturemea,
        //    Texture2D texturesho, Texture2D texturenail, Texture2D texturepear, Texture2D textureperf, Texture2D texturewat, Texture2D texturescr,
        //    Texture2D texturetpap, Texture2D texturetpt, Texture2D texturetow, Texture2D texturetv)
        //{
        //    screwDriver = sdTexture;
        //    apple = textureap;
        //    banana = textureba;
        //    burrito = texturebu;
        //    coffee = textureco;
        //    computer = texturecom;
        //    gold = texturegold;
        //    golf = texturegolf;
        //    granateLuncher = texturegra;
        //    hammer = textureham;
        //    measureTape = texturemea;
        //    shovel = texturesho;
        //    nailPolish = texturenail;
        //    pear = texturepear;
        //    perfume = textureperf;
        //    watch = texturewat;
        //    scrum = texturescr;
        //    toiletPaper = texturetpt;

        //}


    }
}





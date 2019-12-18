using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using WalMart.Astar;

namespace WalMart
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class GameWorld : Game
    {
        
        SpriteFont font; 
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Texture2D playerBlack;
        private Texture2D playerBlue;
        private Texture2D playerGreen;
     

        ShoppingList shoppingList = new ShoppingList(); 


        public GameWorld()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            graphics.PreferredBackBufferWidth = 2400;
            graphics.PreferredBackBufferHeight = 1200;

        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
            spriteBatch.Begin();
            playerBlack = Content.Load<Texture2D>("BasketBlack");
            playerBlue = Content.Load<Texture2D>("BasketGreen");
            playerGreen = Content.Load<Texture2D>("BasketBlue");
            
            ShoppingList.apple = Content.Load<Texture2D>("Apple");
            ShoppingList.pear = Content.Load<Texture2D>("Pear");
            ShoppingList.banana = Content.Load<Texture2D>("banana");
            ShoppingList.burrito = Content.Load<Texture2D>("Burrito");
            ShoppingList.coffee = Content.Load<Texture2D>("Coffee");
            ShoppingList.hammer = Content.Load<Texture2D>("hammer");
            ShoppingList.screwDriver = Content.Load<Texture2D>("ScrewDriver");
            ShoppingList.shovel = Content.Load<Texture2D>("Shovel");
            ShoppingList.measureTape = Content.Load<Texture2D>("MeasureTape");
            ShoppingList.nailPolish = Content.Load<Texture2D>("NailPolish");
            ShoppingList.perfume = Content.Load<Texture2D>("Perfume");
            ShoppingList.toiletPaper = Content.Load<Texture2D>("ToiletPaper");
            ShoppingList.toothPaste = Content.Load<Texture2D>("ToothPaste");
            ShoppingList.towel = Content.Load<Texture2D>("Towel");
            ShoppingList.gold = Content.Load<Texture2D>("gold");
            ShoppingList.scrum = Content.Load<Texture2D>("Scrum");
            ShoppingList.computer = Content.Load<Texture2D>("Computer");
            ShoppingList.tv = Content.Load<Texture2D>("Tv");
            ShoppingList.watch = Content.Load<Texture2D>("Watch");
            ShoppingList.golf = Content.Load<Texture2D>("Golf");
            ShoppingList.granateLuncher = Content.Load<Texture2D>("GranateLuncher");
            shoppingList.ListBlack = Content.Load<Texture2D>("ListBlack");
            shoppingList.ListGreen = Content.Load<Texture2D>("ListGreen");
            shoppingList.ListBlue = Content.Load<Texture2D>("ListRed"); 
            Texture2D tileBlock = Content.Load<Texture2D>("TileBlock");
            font = Content.Load<SpriteFont>("Font");

            Pathfinder.GetTexture(tileBlock);
            Level.GetTexture(tileBlock);

            spriteBatch.End();

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
           
            spriteBatch.Begin();
            Level.Draw(spriteBatch);
            spriteBatch.Draw(playerBlack,new Rectangle(1700,50, 70, 70),Color.White);
            spriteBatch.Draw(playerBlue, new Rectangle(1700,550, 70, 70), Color.White);
            spriteBatch.Draw(playerGreen, new Rectangle(1700,300, 70, 70), Color.White);
            //spriteBatch.Draw(shoppingList.apple, new Rectangle(300, 300, 70, 70), Color.White);
            //spriteBatch.Draw(shoppingList.burrito, new Rectangle(400,300, 70, 70), Color.White);
            //spriteBatch.Draw(shoppingList.coffee, new Rectangle(500, 300, 70, 70), Color.White);
            //spriteBatch.Draw(shoppingList.banana, new Rectangle(600, 300, 70, 70), Color.White);
            //spriteBatch.Draw(shoppingList.pear, new Rectangle(700, 300, 70, 70), Color.White);
            //spriteBatch.Draw(shoppingList.hammer, new Rectangle(300, 500, 70, 70), Color.White);
            //spriteBatch.Draw(shoppingList.measureTape, new Rectangle(400,500, 70, 70), Color.White);
            //spriteBatch.Draw(shoppingList.shovel, new Rectangle(500, 500, 70, 70), Color.White);
            //spriteBatch.Draw(shoppingList.screwDriver, new Rectangle(600,500, 70, 70), Color.White);
            //spriteBatch.Draw(shoppingList.gold, new Rectangle(300, 700, 70, 70), Color.White);
            //spriteBatch.Draw(shoppingList.scrum, new Rectangle(400, 700, 70, 70), Color.White);
            //spriteBatch.Draw(shoppingList.nailPolish, new Rectangle(300, 600, 70, 70), Color.White);
            //spriteBatch.Draw(shoppingList.toiletPaper, new Rectangle(400,600, 70, 70), Color.White);
            //spriteBatch.Draw(shoppingList.perfume ,new Rectangle(500,600, 70, 70), Color.White);
            //spriteBatch.Draw(shoppingList.toothPaste ,new Rectangle(600,600, 70, 70), Color.White);
            //spriteBatch.Draw(shoppingList.towel ,new Rectangle(700,600, 70, 70), Color.White);
            //spriteBatch.Draw(shoppingList.golf, new Rectangle(300, 400, 70, 70), Color.White);
            //spriteBatch.Draw(shoppingList.granateLuncher, new Rectangle(400, 400, 70, 70), Color.White);
            //spriteBatch.Draw(shoppingList.watch, new Rectangle(500, 400, 70, 70), Color.White);
            //spriteBatch.Draw(shoppingList.computer, new Rectangle(600, 400, 70, 70), Color.White);
            //spriteBatch.Draw(shoppingList.tv, new Rectangle(700, 400, 70, 70), Color.White);
            //spriteBatch.Draw(shoppingList.ListBlack, new Rectangle(1700, 100, 200, 200), Color.Black);
            //spriteBatch.Draw(shoppingList.ListBlue, new Rectangle(1700, 350, 200, 200), Color.Blue);
            //spriteBatch.Draw(shoppingList.ListGreen, new Rectangle(1700, 600, 200, 200), Color.Green);
            SortItems(); 
            
            spriteBatch.End();
            
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
        public void SortItems()
        {
            Texture2D[] items = {ShoppingList.screwDriver, ShoppingList.apple, ShoppingList.banana, ShoppingList.burrito, ShoppingList.coffee,
                                ShoppingList.computer, ShoppingList.gold, ShoppingList.golf, ShoppingList.granateLuncher, ShoppingList.hammer,
                                ShoppingList.measureTape, ShoppingList.shovel, ShoppingList.nailPolish, ShoppingList.pear, ShoppingList.perfume,
                                ShoppingList.screwDriver, ShoppingList.scrum, ShoppingList.toiletPaper, ShoppingList.toothPaste, ShoppingList.towel,
                                ShoppingList.tv, ShoppingList.watch}; 
            string[] list = new string[5];
            Random rnd = new Random();


            foreach (Texture2D item in items)
            {
                for (int i = 0; i <= 5; i++)
                {


                    list[0] = rnd.Next(0, items.Length).ToString();
                    list[1] = rnd.Next(0, items.Length).ToString();
                    list[2] = rnd.Next(0, items.Length).ToString();
                    list[3] = rnd.Next(0, items.Length).ToString();
                    list[4] = rnd.Next(0, items.Length).ToString();


                    spriteBatch.DrawString(font, list[0], new Vector2(1900, 700), Color.Black);

                }
                
            }


        }
    }
}

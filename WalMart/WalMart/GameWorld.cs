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
        private Texture2D player;
        private Texture2D player2;
        private Texture2D player3;
     

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
            player = Content.Load<Texture2D>("BasketBlack");
            player2 = Content.Load<Texture2D>("BasketGreen");
            player3 = Content.Load<Texture2D>("BasketBlue");
            
            shoppingList.apple = Content.Load<Texture2D>("Apple");
            shoppingList.pear = Content.Load<Texture2D>("Pear");
            shoppingList.banana = Content.Load<Texture2D>("banana");
            shoppingList.burrito = Content.Load<Texture2D>("Burrito");
            shoppingList.coffee = Content.Load<Texture2D>("Coffee");
            shoppingList.hammer = Content.Load<Texture2D>("hammer");
            shoppingList.screwDriver = Content.Load<Texture2D>("ScrewDriver");
            shoppingList.shovel = Content.Load<Texture2D>("Shovel");
            shoppingList.measureTape = Content.Load<Texture2D>("MeasureTape");
            shoppingList.nailPolish = Content.Load<Texture2D>("NailPolish");
            shoppingList.perfume = Content.Load<Texture2D>("Perfume");
            shoppingList.toiletPaper = Content.Load<Texture2D>("ToiletPaper");
            shoppingList.toothPaste = Content.Load<Texture2D>("ToothPaste");
            shoppingList.towel = Content.Load<Texture2D>("Towel");
            shoppingList.gold = Content.Load<Texture2D>("gold");
            shoppingList.scrum = Content.Load<Texture2D>("Scrum");
            shoppingList.computer = Content.Load<Texture2D>("Computer");
            shoppingList.tv = Content.Load<Texture2D>("Tv");
            shoppingList.watch = Content.Load<Texture2D>("Watch");
            shoppingList.golf = Content.Load<Texture2D>("Golf");
            shoppingList.granateLuncher = Content.Load<Texture2D>("GranateLuncher");
            shoppingList.ListBlack = Content.Load<Texture2D>("ListBlack");
            shoppingList.ListGreen = Content.Load<Texture2D>("ListGreen");
            shoppingList.ListBlue = Content.Load<Texture2D>("ListRed"); 
            Texture2D tileBlock = Content.Load<Texture2D>("TileBlock");
            font = Content.Load<SpriteFont>("Font"); 

            
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
            spriteBatch.Draw(player,new Vector2(1700,50),Color.White);
            spriteBatch.Draw(player2, new Vector2(1700,550), Color.White);
            spriteBatch.Draw(player3, new Vector2(1700,300), Color.White);
            spriteBatch.Draw(shoppingList.apple, new Vector2(300, 300), Color.White);
            spriteBatch.Draw(shoppingList.burrito, new Vector2(400,300), Color.White);
            spriteBatch.Draw(shoppingList.coffee, new Vector2(500, 300), Color.White);
            spriteBatch.Draw(shoppingList.banana, new Vector2(600, 300), Color.White);
            spriteBatch.Draw(shoppingList.pear, new Vector2(700, 300), Color.White);
            spriteBatch.Draw(shoppingList.hammer, new Vector2(300, 500), Color.White);
            spriteBatch.Draw(shoppingList.measureTape, new Vector2(400,500), Color.White);
            spriteBatch.Draw(shoppingList.shovel, new Vector2(500, 500), Color.White);
            spriteBatch.Draw(shoppingList.screwDriver, new Vector2(600,500), Color.White);
            spriteBatch.Draw(shoppingList.gold, new Vector2(300, 700), Color.White);
            spriteBatch.Draw(shoppingList.scrum, new Vector2(400, 700), Color.White);
            spriteBatch.Draw(shoppingList.nailPolish, new Vector2(300, 600), Color.White);
            spriteBatch.Draw(shoppingList.toiletPaper, new Vector2(400,600), Color.White);
            spriteBatch.Draw(shoppingList.perfume ,new Vector2(500,600), Color.White);
            spriteBatch.Draw(shoppingList.toothPaste ,new Vector2(600,600), Color.White);
            spriteBatch.Draw(shoppingList.towel ,new Vector2(700,600), Color.White);
            spriteBatch.Draw(shoppingList.golf, new Vector2(300, 400), Color.White);
            spriteBatch.Draw(shoppingList.granateLuncher, new Vector2(400, 400), Color.White);
            spriteBatch.Draw(shoppingList.watch, new Vector2(500, 400), Color.White);
            spriteBatch.Draw(shoppingList.computer, new Vector2(600, 400), Color.White);
            spriteBatch.Draw(shoppingList.tv, new Vector2(700, 400), Color.White);
            spriteBatch.Draw(shoppingList.ListBlack, new Rectangle(1700, 100, 200, 200), Color.Black);
            spriteBatch.Draw(shoppingList.ListBlue, new Rectangle(1700, 350, 200, 200), Color.Blue);
            spriteBatch.Draw(shoppingList.ListGreen, new Rectangle(1700, 600, 200, 200), Color.Green);
            SortItems(); 
            Level.Draw(spriteBatch);
            spriteBatch.End();
            
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
        public void SortItems()
        {
            Texture2D[] items = {shoppingList.screwDriver, shoppingList.apple, shoppingList.banana, shoppingList.burrito, shoppingList.coffee,
                                shoppingList.computer, shoppingList.gold, shoppingList.golf, shoppingList.granateLuncher, shoppingList.hammer,
                                shoppingList.measureTape, shoppingList.shovel, shoppingList.nailPolish, shoppingList.pear, shoppingList.perfume,
                                shoppingList.screwDriver, shoppingList.scrum, shoppingList.toiletPaper, shoppingList.toothPaste, shoppingList.towel,
                                shoppingList.tv, shoppingList.watch}; 
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


                    spriteBatch.DrawString(font, list[0], new Vector2(100, 100), Color.Black);

                }
                
            }


        }
    }
}

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Threading;
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
        
        Vector2 sprtPos; 

        ShoppingList shoppingList = new ShoppingList();
        TestCustomer customer = new TestCustomer(1900,700);
       


        public GameWorld()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            graphics.PreferredBackBufferWidth = 2400;
            graphics.PreferredBackBufferHeight = 1200;

            Thread cus1 = new Thread(customer.findPath);
            Thread cus2 = new Thread(customer.findPath);
            Thread cus3 = new Thread(customer.findPath);

        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {

            LoadContent();
            sprtPos = new Vector2(1900, 700); 


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
            playerBlue = Content.Load<Texture2D>("BasketBlue");
            playerGreen = Content.Load<Texture2D>("BasketGreen");

            customer.shoplist.apple = Content.Load<Texture2D>("Apple");
            customer.shoplist.pear = Content.Load<Texture2D>("Pear");
            customer.shoplist.banana = Content.Load<Texture2D>("banana");
            customer.shoplist.burrito = Content.Load<Texture2D>("Burrito");
            customer.shoplist.coffee = Content.Load<Texture2D>("Coffee");
            customer.shoplist.hammer = Content.Load<Texture2D>("hammer");
            customer.shoplist.screwDriver = Content.Load<Texture2D>("ScrewDriver");
            customer.shoplist.shovel = Content.Load<Texture2D>("Shovel");
            customer.shoplist.measureTape = Content.Load<Texture2D>("MeasureTape");
            customer.shoplist.nailPolish = Content.Load<Texture2D>("NailPolish");
            customer.shoplist.perfume = Content.Load<Texture2D>("Perfume");
            customer.shoplist.toiletPaper = Content.Load<Texture2D>("ToiletPaper");
            customer.shoplist.toothPaste = Content.Load<Texture2D>("ToothPaste");
            customer.shoplist.towel = Content.Load<Texture2D>("Towel");
            customer.shoplist.gold = Content.Load<Texture2D>("gold");
            customer.shoplist.scrum = Content.Load<Texture2D>("Scrum");
            customer.shoplist.computer = Content.Load<Texture2D>("Computer");
            customer.shoplist.tv = Content.Load<Texture2D>("Tv");
            customer.shoplist.watch = Content.Load<Texture2D>("Watch");
            customer.shoplist.golf = Content.Load<Texture2D>("Golf");
            customer.shoplist.granateLuncher = Content.Load<Texture2D>("GranateLuncher");
            customer.shoplist.ListBlack = Content.Load<Texture2D>("ListBlack");
            customer.shoplist.ListGreen = Content.Load<Texture2D>("ListGreen");
            customer.shoplist.ListBlue = Content.Load<Texture2D>("ListBlue"); 
            Texture2D tileBlock = Content.Load<Texture2D>("TileBlock");
            font = Content.Load<SpriteFont>("Font");
            customer.font = Content.Load<SpriteFont>("Font");

            Pathfinder.GetTexture(tileBlock);
            Level.GetTexture(tileBlock, customer.shoplist.computer, customer.shoplist.screwDriver, customer.shoplist.shovel, customer.shoplist.watch, 
                customer.shoplist.measureTape, customer.shoplist.perfume, customer.shoplist.toiletPaper, customer.shoplist.toothPaste, customer.shoplist.hammer, 
                customer.shoplist.apple, customer.shoplist.banana, customer.shoplist.burrito, customer.shoplist.pear, customer.shoplist.coffee, customer.shoplist.gold, 
                customer.shoplist.tv, customer.shoplist.scrum, customer.shoplist.nailPolish, customer.shoplist.golf, customer.shoplist.granateLuncher, customer.shoplist.towel);


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
            customer.Draw(spriteBatch);
            spriteBatch.Draw(playerBlack, new Rectangle(1700, 50, 70, 70), Color.White);
            spriteBatch.Draw(playerBlue, new Rectangle(1700, 300, 70, 70), Color.White);
            spriteBatch.Draw(playerGreen, new Rectangle(1700, 550, 70, 70), Color.White);
            spriteBatch.Draw(customer.shoplist.ListBlack, new Rectangle(1700, 100, 200, 200), Color.Black);
            spriteBatch.Draw(customer.shoplist.ListBlue, new Rectangle(1700, 350, 200, 200), Color.Blue);
            spriteBatch.Draw(customer.shoplist.ListGreen, new Rectangle(1700, 600, 200, 200), Color.Green);

            // spriteBatch.Draw(SortItems(), new Vector2(2000, 700), Color.White);

            spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}

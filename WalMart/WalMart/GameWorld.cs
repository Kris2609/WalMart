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
        Random rnd = new Random(); 

        Vector2 sprtPos; 

        Texture2D[] items = new Texture2D[21]; 
     

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

            LoadContent();
            sprtPos = new Vector2(1900, 700); 

            items[0] = shoppingList.screwDriver;
            items[1] = shoppingList.apple;
            items[2] = shoppingList.banana;
            items[3] = shoppingList.burrito;
            items[4] = shoppingList.coffee;
            items[5] = shoppingList.computer;
            items[6] = shoppingList.gold;
            items[7] = shoppingList.golf;
            items[8] = shoppingList.granateLuncher;
            items[9] = shoppingList.hammer;
            items[10] = shoppingList.measureTape;
            items[11] = shoppingList.shovel;
            items[12] = shoppingList.nailPolish;
            items[13] = shoppingList.pear;
            items[14] = shoppingList.perfume;
            items[15] = shoppingList.watch; 
            items[16] = shoppingList.scrum;
            items[17] = shoppingList.toiletPaper;
            items[18] = shoppingList.toothPaste;
            items[19] = shoppingList.towel; 
            items[20] = shoppingList.tv; 

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
            spriteBatch.Draw(playerBlack, new Rectangle(1700, 50, 70, 70), Color.White);
            spriteBatch.Draw(playerBlue, new Rectangle(1700, 550, 70, 70), Color.White);
            spriteBatch.Draw(playerGreen, new Rectangle(1700, 300, 70, 70), Color.White);
            spriteBatch.Draw(shoppingList.apple, new Rectangle(300, 300, 70, 70), Color.White);
            spriteBatch.Draw(shoppingList.burrito, new Rectangle(400, 300, 70, 70), Color.White);
            spriteBatch.Draw(shoppingList.coffee, new Rectangle(500, 300, 70, 70), Color.White);
            spriteBatch.Draw(shoppingList.banana, new Rectangle(600, 300, 70, 70), Color.White);
            spriteBatch.Draw(shoppingList.pear, new Rectangle(700, 300, 70, 70), Color.White);
            spriteBatch.Draw(shoppingList.hammer, new Rectangle(300, 500, 70, 70), Color.White);
            spriteBatch.Draw(shoppingList.measureTape, new Rectangle(400, 500, 70, 70), Color.White);
            spriteBatch.Draw(shoppingList.shovel, new Rectangle(500, 500, 70, 70), Color.White);
            spriteBatch.Draw(shoppingList.screwDriver, new Rectangle(600, 500, 70, 70), Color.White);
            spriteBatch.Draw(shoppingList.gold, new Rectangle(300, 700, 70, 70), Color.White);
            spriteBatch.Draw(shoppingList.scrum, new Rectangle(400, 700, 70, 70), Color.White);
            spriteBatch.Draw(shoppingList.nailPolish, new Rectangle(300, 600, 70, 70), Color.White);
            spriteBatch.Draw(shoppingList.toiletPaper, new Rectangle(400, 600, 70, 70), Color.White);
            spriteBatch.Draw(shoppingList.perfume, new Rectangle(500, 600, 70, 70), Color.White);
            spriteBatch.Draw(shoppingList.toothPaste, new Rectangle(600, 600, 70, 70), Color.White);
            spriteBatch.Draw(shoppingList.towel, new Rectangle(700, 600, 70, 70), Color.White);
            spriteBatch.Draw(shoppingList.golf, new Rectangle(300, 400, 70, 70), Color.White);
            spriteBatch.Draw(shoppingList.granateLuncher, new Rectangle(400, 400, 70, 70), Color.White);
            spriteBatch.Draw(shoppingList.watch, new Rectangle(500, 400, 70, 70), Color.White);
            spriteBatch.Draw(shoppingList.computer, new Rectangle(600, 400, 70, 70), Color.White);
            spriteBatch.Draw(shoppingList.tv, new Rectangle(700, 400, 70, 70), Color.White);
            spriteBatch.Draw(shoppingList.ListBlack, new Rectangle(1700, 100, 200, 200), Color.Black);
            spriteBatch.Draw(shoppingList.ListBlue, new Rectangle(1700, 350, 200, 200), Color.Blue);
            spriteBatch.Draw(shoppingList.ListGreen, new Rectangle(1700, 600, 200, 200), Color.Green);






            // spriteBatch.Draw(SortItems(), new Vector2(2000, 700), Color.White);

            spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}

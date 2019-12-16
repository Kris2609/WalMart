using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using WalMart.Astar;
using System; 

namespace WalMart
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class GameWorld : Game
    {
        Level level = new Level();

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Texture2D player;
        private Texture2D player2;
        private Texture2D player3;
        //private Texture2D apple;
        //private Texture2D banana;
        //private Texture2D pear;
        //private Texture2D burrito;
        //private Texture2D coffee;
        //private Texture2D hammer;
        //private Texture2D measureTape;
        //private Texture2D shovel; 
        //private Texture2D screwDriver;
        //private Texture2D gold;
        //private Texture2D scrum;
        //private Texture2D nailPolish;
        //private Texture2D perfume;
        //private Texture2D toiletPaper;
        //private Texture2D toothPaste;
        //private Texture2D towel;
        //private Texture2D tv;
        //private Texture2D computer;
        //private Texture2D granateLuncher;
        //private Texture2D watch;
        //private Texture2D golf;

        


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
            ShoppingList shoppingList = new ShoppingList(); 
            spriteBatch.Begin();
            player = Content.Load<Texture2D>("BasketBlack");
            player2 = Content.Load<Texture2D>("BasketGreen");
            player3 = Content.Load<Texture2D>("BasketRed");
            
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
            Texture2D tileBlock = Content.Load<Texture2D>("TileBlock");
            level.GetTexture(tileBlock);

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
            spriteBatch.Draw(player,new Vector2(100,100),Color.Black);
            spriteBatch.Draw(player2, new Vector2(200,100), Color.Green);
            spriteBatch.Draw(player3, new Vector2(300,100), Color.Red);
            spriteBatch.Draw(apple, new Vector2(300, 300), Color.White);
            spriteBatch.Draw(burrito, new Vector2(400,300), Color.White);
            spriteBatch.Draw(coffee, new Vector2(500, 300), Color.White);
            spriteBatch.Draw(banana, new Vector2(600, 300), Color.White);
            spriteBatch.Draw(pear, new Vector2(700, 300), Color.White);
            spriteBatch.Draw(hammer, new Vector2(300, 500), Color.White);
            spriteBatch.Draw(measureTape, new Vector2(400,500), Color.White);
            spriteBatch.Draw(shovel, new Vector2(500, 500), Color.White);
            spriteBatch.Draw(screwDriver, new Vector2(600,500), Color.White);
            spriteBatch.Draw(gold, new Vector2(300, 700), Color.White);
            spriteBatch.Draw(scrum, new Vector2(400, 700), Color.White);
            spriteBatch.Draw(nailPolish, new Vector2(300, 600), Color.White);
            spriteBatch.Draw(toiletPaper, new Vector2(400,600), Color.White);
            spriteBatch.Draw(perfume ,new Vector2(500,600), Color.White);
            spriteBatch.Draw(toothPaste ,new Vector2(600,600), Color.White);
            spriteBatch.Draw(towel ,new Vector2(700,600), Color.White);
            spriteBatch.Draw(golf, new Vector2(300, 400), Color.White);
            spriteBatch.Draw(granateLuncher, new Vector2(400, 400), Color.White);
            spriteBatch.Draw(watch, new Vector2(500, 400), Color.White);
            spriteBatch.Draw(computer, new Vector2(600, 400), Color.White);
            spriteBatch.Draw(tv, new Vector2(700, 400), Color.White);
            level.Draw(spriteBatch);
            spriteBatch.End();
            
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}

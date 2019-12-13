using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace WalMart
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class GameWorld : Game
    {
        
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Texture2D player;
        private Texture2D player2;
        private Texture2D player3;
        private Texture2D apple;
        private Texture2D banana;
        private Texture2D pear;
        private Texture2D burrito;
        private Texture2D medicin;
        private Texture2D hammer;
        private Texture2D measureTape;
        private Texture2D gold;

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
            player3 = Content.Load<Texture2D>("BasketRed");
            apple = Content.Load<Texture2D>("Apple");
            pear = Content.Load<Texture2D>("Pear");
            banana = Content.Load<Texture2D>("banana");
            burrito = Content.Load<Texture2D>("Burrito");
            medicin = Content.Load<Texture2D>("medicin");
            hammer = Content.Load<Texture2D>("hammer");
            measureTape = Content.Load<Texture2D>("MeasureTape");
            
            gold = Content.Load<Texture2D>("gold");
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
            spriteBatch.Draw(player,new Vector2(750,750),Color.Black);
            spriteBatch.Draw(player2, new Vector2(500,500), Color.Green);
            spriteBatch.Draw(player3, new Vector2(250,250), Color.Red);
            spriteBatch.Draw(apple, new Vector2(300, 300), Color.White);
            spriteBatch.Draw(burrito, new Vector2(900,300), Color.White);
            spriteBatch.Draw(medicin, new Vector2(400, 300), Color.White);
            spriteBatch.Draw(hammer, new Vector2(500, 300), Color.White);
            spriteBatch.Draw(measureTape, new Vector2(1000,300), Color.White);
            spriteBatch.Draw(banana, new Vector2(600, 300), Color.White);
            spriteBatch.Draw(gold, new Vector2(700, 300), Color.White);
            spriteBatch.Draw(pear, new Vector2(800, 300), Color.White);
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}

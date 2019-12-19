using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalMart
{
    
    class varer
    {
        string name;
        Vector2 position;
        Texture2D spritename;
        ContentManager ContentManager;
        public varer(Vector2 startposition, string name)
        {
            position = startposition;
            spritename = ContentManager.Load<Texture2D>(name);

        }
        public virtual void Update(GameTime gameTime)
        {

        }

      
        public virtual void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(spritename, position, Color.White);
        }
    }
}


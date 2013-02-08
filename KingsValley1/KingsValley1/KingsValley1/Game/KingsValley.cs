using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace KingsValley1
{
    public class KingsValley : Microsoft.Xna.Framework.Game
    {
        //Fields
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private Explorer explorer;

        //Properties
        public SpriteBatch SpriteBatch
        {
            get { return this.spriteBatch; }
        }
        
        //Constructor
        public KingsValley()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        //Initialize method
        protected override void Initialize()
        {
            IsMouseVisible = true;
            this.Window.Title = "KingsValley I Beta";
            this.graphics.PreferredBackBufferWidth = 640;
            this.graphics.PreferredBackBufferHeight = 480;
            this.graphics.ApplyChanges();
            base.Initialize();
        }

        //LoadContent method
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            this.explorer = new Explorer(this, new Vector2(100f, 300f));
        }

        //UnloadContent 
        protected override void UnloadContent()
        {
            
        }

        //Update
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            Input.Update();
            this.explorer.Update(gameTime);
            base.Update(gameTime);
        }

        //Draw
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(new Color(6,6,6));
            this.spriteBatch.Begin();
            this.explorer.Draw(gameTime);
            this.spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}

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
    public class ExplorerIdleRight : AnimatedSprite
    {
        //Fields
        private Explorer explorer;

        //Constructor
        public ExplorerIdleRight(Explorer explorer) : base(explorer)
        {
            this.explorer = explorer;
            this.i = 7;
        }

        public override void Update(GameTime gameTime)
        {
            if (Input.DetectKeyDown(Keys.Right))
            {
                this.explorer.State = this.explorer.WalkRight;
            }
            //base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}

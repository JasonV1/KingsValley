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
    public class ExplorerWalkRight : AnimatedSprite
    {
        //Fields
        private Explorer explorer;
        //Properties

        //Constructor
        public ExplorerWalkRight(Explorer explorer) : base(explorer)
        {
            this.explorer = explorer;
        }

        //Update
        public override void Update(GameTime gameTime)
        {
            this.explorer.Position += new Vector2(this.explorer.Speed, 0f);
            if (Input.EdgeDetectKeyUp(Keys.Right))
            {
                this.explorer.State = this.explorer.IdleRight;
            }
            base.Update(gameTime);
        }

        //Draw
        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}

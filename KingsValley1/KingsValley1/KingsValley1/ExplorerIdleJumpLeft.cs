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
    public class ExplorerIdleJumpLeft : AnimatedSprite
    {
        //Fields
        private Explorer explorer;
        private float startX, startY, a, x;
        private int startH, startK, h, k;

        //Constructor
        public ExplorerIdleJumpLeft(Explorer explorer, int h, int k)
            : base(explorer)
        {
            this.explorer = explorer;
            this.startK = k;
            this.startH = h;
            this.i = 0;
            this.effect = SpriteEffects.FlipHorizontally;
        }

        public void Initialize()
        {
            this.startX = this.explorer.Position.X;
            this.startY = this.explorer.Position.Y;
            this.h = (int)(this.startX + startH);
            this.k = (int)(this.startY - startK);
            this.a = this.CalculateA();
            this.x = this.startX;
        }

        private float CalculateA()
        {
            float result = (this.startY - this.k) / (float)Math.Pow((double)(this.startX - this.h), 2d);
            return result;
        }

        public override void Update(GameTime gameTime)
        {
            this.x = this.x + this.explorer.Speed;
            float y = (float)(this.a * Math.Pow(this.x - this.h, 2d) + this.k);
            float x = this.startX;
            this.explorer.Position = new Vector2(x, y);
            if (this.explorer.Position.Y > this.startY)
            {
                this.explorer.State = this.explorer.IdleLeft;
                this.explorer.Position = new Vector2(x, startY);
            }

            // base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}

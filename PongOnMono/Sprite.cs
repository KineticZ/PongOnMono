using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace PongOnMono
{
    public class Sprite
    {
        protected Vector2 position;        
        private Texture2D texture;
        private Color tint;

        protected Vector2 Speed { get; set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Rectangle HitBox => new Rectangle(position.ToPoint(), new Point(Width, Height));
        public int X
        {
            get
            {
                return (int)position.X;
            }
            set
            {
                position.X = value;
            }
        }
        public int Y
        {
            get
            {
                return (int)position.Y;
            }
            set
            {
                position.Y = value;
            }
        }
        public Sprite(Vector2 position, Texture2D texture, int width, int height, Vector2 speed, Color tint)
        {
            this.position = position;
            this.texture = texture;
            Width = width;
            Height = height;
            Speed = speed;
            this.tint = tint;
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, HitBox, tint);
        }

    }
}

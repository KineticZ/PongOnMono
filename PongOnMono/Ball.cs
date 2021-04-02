using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace PongOnMono
{

    public class Ball : Sprite
    {
        private int diameter;

        public Ball(Vector2 position, int diameter, Texture2D texture, Vector2 speed, Color tint)
            : base(position, texture, diameter, diameter, speed, tint)
        {
            this.diameter = diameter; 
        }              

        public void Bounce(Rectangle boundary)
        {
            position += Speed;
            if (position.X + diameter >= boundary.Width)
            {
                Speed = new Vector2(-Math.Abs(Speed.X), Speed.Y);
            }
            else if(position.X < boundary.X)
            {
                Speed = new Vector2(Math.Abs(Speed.X), Speed.Y);
            }

            if (position.Y + diameter >= boundary.Height)
            {
                Speed = new Vector2(Speed.X, -Math.Abs(Speed.Y));
            }
            else if (position.Y <= boundary.Y)
            {
                Speed = new Vector2(Speed.X, Math.Abs(Speed.Y));
            }

        }
    }
}
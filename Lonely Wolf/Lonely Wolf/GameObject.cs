﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Lonely_Wolf
{
    public abstract class GameObject
    {
        private int id;
        private int x;
        private int y;
        private int width;
        private int height;
        private Rectangle rectangle;

        protected GameObject(int x, int y, int width, int height, Rectangle rectangle)
        {

            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.Rectangle = rectangle;
        }
        public int Id
        {
            get { return this.id; }
            private set { id = value; }
        }
        public Rectangle Rectangle
        {
            get { return this.rectangle; }
            set { this.rectangle = value; }
        }
        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public int Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

    }
}

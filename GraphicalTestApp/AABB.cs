﻿using System;

namespace GraphicalTestApp
{
    class AABB : Actor
    {
        Raylib.Color _color = Raylib.Color.RED;

        public float Width { get; set; } = 1;
        public float Height { get; set; } = 1;

        //Returns the Y coordinate at the top of the box
        public float Top
        {
            get { return YAbsolute - Height / 2; }
        }

        //Returns the Y coordinate at the top of the box
        public float Bottom
        {
            get { return YAbsolute + Height / 2; }
        }

        //Returns the X coordinate at the top of the box
        public float Left
        {
            get { return XAbsolute - Width / 2; }
        }

        //Returns the X coordinate at the top of the box
        public float Right
        {
            get { return XAbsolute + Width / 2; }
        }

        //Creates an AABB of the specifed size
        public AABB(float width, float height)
        {
            Width = width;
            Height = height;
        }

        public bool DetectCollision(AABB other)
        {
            if (Right >= other.Left && Bottom >= other.Top && Left <= other.Right && Top <= other.Bottom)
            {
                _color = Raylib.Color.BLUE;
                return true;
            }
            else
            {
                _color = Raylib.Color.GREEN;
            }
            return false;
        }

        public bool DetectCollision(Vector3 point)
        {
            return !(point.x < Bottom || point.y < Left || point.x > Right || point.y > Top);
        }

        //Draw the bounding box to the screen
        public override void Draw()
        {
            Raylib.Rectangle rec = new Raylib.Rectangle(
                XAbsolute - Width / 2,
                YAbsolute - Height / 2,
                Width,
                Height);

            Raylib.Raylib.DrawRectangleLinesEx(rec, 5, _color);
            base.Draw();
        }
    }
}

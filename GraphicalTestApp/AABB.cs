using System;

namespace GraphicalTestApp
{
    class AABB : Actor
    {
        //A private Color so the Color can be changed on collision
        private Raylib.Color _color = Raylib.Color.RED;

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

        //Detects if collison is hit turning one box blue
        public bool DetectCollision(AABB other)
        {
            if (Right >= other.Left && Bottom >= other.Top && Left <= other.Right && Top <= other.Bottom)
            {
                //turns the box blue while collison is detected
                _color = Raylib.Color.BLUE;
                return true;
            }
            else
            {
                //If no collision then the box is green
                _color = Raylib.Color.GREEN;
                return false;
            }
        }

        public override void Draw()
        {
            //Draw the bounding box to the screen
            Raylib.Rectangle rec = new Raylib.Rectangle(
                XAbsolute - Width / 2,
                YAbsolute - Height / 2,
                Width,
                Height);

            //Allows the color to be changed
            Raylib.Raylib.DrawRectangleLinesEx(rec, 5, _color);
            base.Draw();
        }
    }
}

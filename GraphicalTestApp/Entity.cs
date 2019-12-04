using System;

namespace GraphicalTestApp
{
    class Entity : Actor
    {
        private Vector3 _velocity = new Vector3();
        private Vector3 _acceleration = new Vector3();

        

        public float XVelocity
        {
            get { return _velocity.x; }
            
            set
            {
                _velocity.x = value;
            }
        }
        public float XAcceleration
        {
            //## Implement acceleration on the X axis ##//
            get { return 0; }
            set { }
        }
        public float YVelocity
        {
            get { return _velocity.y; }
            set
            {
                _velocity.y = value;
            }
        }
        public float YAcceleration
        {
            //## Implement acceleration on the Y axis ##//
            get { return 0; }
            set { }
        }

        //Creates an Entity at the specified coordinates
        public Entity(float x, float y)
        {
            X = x;
            Y = y;
        }

        Player player = new Player(0,0);

        public override void Update(float deltaTime)
        {
            if (Input.IsKeyDown(87))
            {
                player.Y += 100 * deltaTime;
            }
            if (Input.IsKeyDown(83))
            {
                player.Y += 100 * deltaTime;
            }
            //## Calculate velocity from acceleration ##//
            //## Calculate position from velocity ##//
            X += _velocity.x;
            Y += _velocity.y;
            base.Update(deltaTime);
        }
    }
}

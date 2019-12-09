﻿using System;

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
            get { return _acceleration.x; }

            set
            {
                _acceleration.x = value;
            }
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
            get { return _acceleration.y; }

            set
            {
                _acceleration.y = value;
            }
        }

        //Creates an Entity at the specified coordinates
        public Entity(float x, float y)
        {
            X = x;
            Y = y;
        }

        public override void Update(float deltaTime)
        {

            //## Calculate velocity from acceleration ##//
            XVelocity = XVelocity + XAcceleration * deltaTime;
            YVelocity = YVelocity + YAcceleration * deltaTime;
            //## Calculate position from velocity ##//
            X += _velocity.x * deltaTime;
            Y += _velocity.y * deltaTime;
            base.Update(deltaTime);
        }
    }
}

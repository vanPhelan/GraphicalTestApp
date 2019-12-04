using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Player : Entity
    {
        //Creates an Entity at the specified coordinates
        public Player() : base (0,0)
        {
            
        }

        public override void Update(float deltaTime)
        {
            if (Input.IsKeyDown(87))
            {
                Y -= 200f * deltaTime;
            }
            if (Input.IsKeyDown(83))
            {
                Y += 200f * deltaTime;
            }
            if (Input.IsKeyReleased(87))
            {
                Y *= 0 * deltaTime;
            }
            if (Input.IsKeyReleased(83))
            {
                Y *= 0 * deltaTime;
            }
            //## Calculate velocity from acceleration ##//
            //## Calculate position from velocity ##//
            base.Update(deltaTime);
        }
    }
}


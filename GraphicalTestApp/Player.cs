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
        public Player(float x, float y) : base(x, y)
        {

        }

        public override void Update(float deltaTime)
        {

            if (Input.IsKeyDown(65))
            {
                Rotate(-3 * deltaTime);
            }
            if (Input.IsKeyDown(68))
            {
                Rotate(3 * deltaTime);
            }

            //## Calculate velocity from acceleration ##//
            //## Calculate position from velocity ##//
            base.Update(deltaTime);
        }
    }
}


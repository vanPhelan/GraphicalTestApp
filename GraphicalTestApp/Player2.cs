using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Player2 : Entity
    {

        //Creates an Entity at the specified coordinates
        public Player2() : base(0, 0)
        {

        }

        public override void Update(float deltaTime)
        {
            if (Input.IsKeyDown(325))//up arrow
            {
                Y -= .005f * deltaTime;
            }
            if (Input.IsKeyDown(322))//down arrow
            {
                Y += .005f * deltaTime;
            }
            if (Input.IsKeyReleased(325))
            {
                Y *= 0 * deltaTime;
            }
            if (Input.IsKeyReleased(322))
            {
                Y *= 0 * deltaTime;
            }
            //## Calculate velocity from acceleration ##//
            //## Calculate position from velocity ##//
            base.Update(deltaTime);
        }
    }
}

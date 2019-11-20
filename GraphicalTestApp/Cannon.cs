using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Cannon : Entity
    {
        public Cannon() : base (0,0)
        {

        }

        public override void Update(float deltaTime)
        {
            if (Input.IsKeyDown(69))
            {
                if (GetRotation() <= Math.PI / 4)
                {
                    Rotate(4 * deltaTime);
                }
                else
                {
                    return;
                }
            }
            if (Input.IsKeyDown(81))
            {
                if (-GetRotation() <= Math.PI / 4)
                {
                    Rotate(-4 * deltaTime);
                }
                else
                {
                    return;
                }
            }

            base.Update(deltaTime);
        }
    }
}

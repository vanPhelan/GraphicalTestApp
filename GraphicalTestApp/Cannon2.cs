using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Cannon2 : Entity
    {
        public Cannon2() : base(0, 0)
        {

        }

        public override void Update(float deltaTime)
        {
            if (Input.IsKeyDown(326))
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
            if (Input.IsKeyDown(324))
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

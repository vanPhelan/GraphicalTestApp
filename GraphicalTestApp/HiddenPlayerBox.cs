using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class HiddenPlayerBox : Entity
    {
        public HiddenPlayerBox(float x, float y) : base(x, y)
        {

        }

        public override void Update(float deltaTime)
        {
            //Rotates the HiddenPlayerBox with the player
            Program.Player1.X = Program.TankBase.XAbsolute;
            Program.Player1.Y = Program.TankBase.YAbsolute;

            //Sets the TankBase to the center of the HiddenPlayerBox
            Program.TankBase.X = 0;
            Program.TankBase.Y = 0;

            //Rotates Clockwize
            if (Input.IsKeyDown(68))//D
            {
                Rotate(4 * deltaTime);
            }

            //Rotates Counter ClockWize
            if (Input.IsKeyDown(65))//A
            {
                Rotate(-4 * deltaTime);
            }
            base.Update(deltaTime);
        }
    }
}

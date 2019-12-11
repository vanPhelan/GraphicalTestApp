using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class HiddenPlayerBox2 : Entity
    {
        Program program = new Program();



        public HiddenPlayerBox2(float x, float y) : base(x, y)
        {

        }

        public override void Update(float deltaTime)
        {
            //Moves the HiddenPlayerBox2 with the Player2
            Program.Player2.X = Program.TankBase2.XAbsolute;
            Program.Player2.Y = Program.TankBase2.YAbsolute;

            //Sets the TankBase2 to the center of the HiddenPlayerBox2
            Program.TankBase2.X = 0;
            Program.TankBase2.Y = 0;

            //Rotates Clockwize
            if (Input.IsKeyDown(321))// 
            {
                Rotate(-4 * deltaTime);
            }

            //Rotates Counter ClockWize
            if (Input.IsKeyDown(323))
            {
                Rotate(4 * deltaTime);
            }
            base.Update(deltaTime);
        }
    }
}

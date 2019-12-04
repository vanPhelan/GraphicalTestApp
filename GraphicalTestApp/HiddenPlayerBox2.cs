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
                program.GetHidden2().X = program.GetPlayer2().XAbsolute;
                program.GetHidden2().Y = program.GetPlayer2().YAbsolute;
                program.GetPlayer2().X = 0;
                program.GetPlayer2().Y = 0;
            if (Input.IsKeyDown(321))
                {
                    Rotate(-4 * deltaTime);
                }
                if (Input.IsKeyDown(323))
                {
                    Rotate(4 * deltaTime);
                }


                base.Update(deltaTime);
            }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class HiddenPlayerBox : Entity
    {
        Program program = new Program();

        

        public HiddenPlayerBox(float x, float y) : base(x, y)
        {

        }

        public override void Update(float deltaTime)
        {
            program.GetHidden().X = program.GetPlayer().XAbsolute;
            program.GetHidden().Y = program.GetPlayer().YAbsolute;
            if (Input.IsKeyDown(65))
            {
                Rotate(-4 * deltaTime);
            }
            if (Input.IsKeyDown(68))
            {
                Rotate(4 * deltaTime);
            }


            base.Update(deltaTime);
        }
    }
}

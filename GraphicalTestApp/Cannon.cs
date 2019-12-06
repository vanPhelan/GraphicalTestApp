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

            if (Input.IsKeyPressed(32))
            {
                Fire();
            }

            base.Update(deltaTime);
        }
        private void Fire()
        {
            Bullet GreenBullet = new Bullet(Program.cannon.XAbsolute, Program.cannon.YAbsolute);
            GreenBullet.Rotate(Program.cannon.GetRotation());
            GreenBullet.XVelocity = (float)Math.Cos(Program.cannon.GetRotation() - Math.PI * .5f) * 100;
            Parent.Parent.Parent.AddChild(GreenBullet);
        }
    }
}

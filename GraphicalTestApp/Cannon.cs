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
            

            if (Input.IsKeyPressed(32))
            {
                Fire();
            }

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
        private void Fire()
        {
            Bullet GreenBullet = new Bullet(XAbsolute, YAbsolute);

            GreenBullet.Rotate(Parent.Parent.GetRotation() + GetRotation());

            GreenBullet.XVelocity = (float)Math.Cos(GetRotation() + Parent.Parent.GetRotation() - Math.PI * .5f) * 300 ;
            GreenBullet.YVelocity = (float)Math.Sin(GetRotation() + Parent.Parent.GetRotation() - Math.PI * .5f) * 300 ;
            Parent.Parent.Parent.AddChild(GreenBullet);
        }
    }
}

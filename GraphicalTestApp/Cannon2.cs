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
            if (Input.IsKeyPressed(262))
            {
                Fire();
            }

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
        private void Fire()
        {
            Bullet2 RedBullet = new Bullet2(XAbsolute, YAbsolute);

            RedBullet.Rotate(Parent.Parent.GetRotation() + GetRotation());
            
            RedBullet.XVelocity = (float)Math.Cos(GetRotation() + Parent.Parent.GetRotation() - Math.PI * .5f) * 300;
            RedBullet.YVelocity = (float)Math.Sin(GetRotation() + Parent.Parent.GetRotation() - Math.PI * .5f) * 300;
            Parent.Parent.Parent.AddChild(RedBullet);
        }
    }
}

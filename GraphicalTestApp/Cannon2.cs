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
            //Shoots a bullet
            if (Input.IsKeyPressed(262))//RIGHTARROW
            {
                Fire();
            }

            //Rotates the cannon clockwize
            if (Input.IsKeyDown(326))//NumberPad 6
            {
                //Stops the Rotation at a certain extent
                if (GetRotation() <= Math.PI / 4)
                {
                    Rotate(4 * deltaTime);
                }
            }

            //Roataes the cannon counter clockwize
            if (Input.IsKeyDown(324))//NumberPad 4
            {
                //Stops the Rotation at a certain extent
                if (-GetRotation() <= Math.PI / 4)
                {
                    Rotate(-4 * deltaTime);
                }
            }
            base.Update(deltaTime);
        }

        //Shoots a bullet
        private void Fire()
        {
            //Creates a Bullet to shoot
            Bullet2 RedBullet = new Bullet2(XAbsolute, YAbsolute);

            //Gets the Direction the bullet needs to face
            RedBullet.Rotate(Parent.Parent.GetRotation() + GetRotation());

            //Directs the way the bullet needs to travel
            RedBullet.XVelocity = (float)Math.Cos(GetRotation() + Parent.Parent.GetRotation() - Math.PI * .5f) * 300;
            RedBullet.YVelocity = (float)Math.Sin(GetRotation() + Parent.Parent.GetRotation() - Math.PI * .5f) * 300;

            //Adds the bullet to the Scene
            Parent.Parent.Parent.AddChild(RedBullet);
        }
    }
}

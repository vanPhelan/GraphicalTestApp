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
            //Shoots a bullet
            if (Input.IsKeyPressed(32))//SPACE
            {
                Fire();
            }

            //Rotates the cannon clockwize
            if (Input.IsKeyDown(69))//E
            {
                //Stops the Rotation at a certain extent
                if (GetRotation() <= Math.PI / 4)
                {
                    Rotate(4 * deltaTime);
                }
            }

            //Roataes the cannon counter clockwize
            if (Input.IsKeyDown(81))
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
            Bullet GreenBullet = new Bullet(XAbsolute, YAbsolute);

            //Gets the Direction the bullet needs to face
            GreenBullet.Rotate(Parent.Parent.GetRotation() + GetRotation());

            //Directs the way the bullet needs to travel
            GreenBullet.XAcceleration = (float)Math.Cos(GetRotation() + Parent.Parent.GetRotation() - Math.PI * .5f) * 300 ;
            GreenBullet.YAcceleration = (float)Math.Sin(GetRotation() + Parent.Parent.GetRotation() - Math.PI * .5f) * 300 ;

            //Adds the bullet to the Scene
            Parent.Parent.Parent.AddChild(GreenBullet);
        }
    }
}

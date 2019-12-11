using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Bullet2 : Entity
    {
        //Image of the bullet
        private Sprite BulletImage = new Sprite("Images/RedBullet.png");

        //The HitBox of the bullet that gets called out of the bullet class
        private AABB Hitbox;

        public Bullet2(float x, float y) : base(x, y)
        {
            X = x;
            Y = y;
            //HitBox of the bullet
            AABB hitbox = new AABB(BulletImage.Width, BulletImage.Height);

            //Sets the hitbox from the private one
            Hitbox = hitbox;

            //Adds the HitBox and the Image to the bullet
            AddChild(hitbox);
            AddChild(BulletImage);
        }
        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
            //calls bullet Collision
            BulletCollision(deltaTime);
        }
        private void BulletCollision(float deltatime)
        {
            //sees if the bullet is colliding with the other tank
            if (Hitbox.DetectCollision(Program.Player1HitBox))
            {
                //Removes the bullet on collison
                Parent.RemoveChild(this);
            }
        }
    }
}

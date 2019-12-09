using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Bullet : Entity
    {
        private Sprite BulletImage = new Sprite("Images/GreenBullet.png");

        public Bullet(float x , float y) : base(x,y)
        {
            X = x;
            Y = y;

            AABB hitbox = new AABB(BulletImage.Width, BulletImage.Height);

            AddChild(hitbox);
            AddChild(BulletImage);
        }
        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
        }
        private void ShotBullet()
        {

        }
    }
}

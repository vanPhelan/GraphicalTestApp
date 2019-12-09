using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Bullet2 : Entity
    {
        private Sprite BulletImage = new Sprite("Images/RedBullet.png");
        private AABB Hitbox;

        public Bullet2(float x, float y) : base(x, y)
        {
            X = x;
            Y = y;
            AABB hitbox = new AABB(BulletImage.Width, BulletImage.Height);

            hitbox.X += 1;
            hitbox.Y += 1;

            Hitbox = hitbox;

        AddChild(hitbox);
            AddChild(BulletImage);

            OnUpdate += BulletCollision;
        }
        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
        }
        private void BulletCollision(float deltatime)
        {
            if (Hitbox.DetectCollision(Program.box2))
            {
                //Parent.RemoveChild(this);
            }
        }
    }
}

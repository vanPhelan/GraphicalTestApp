using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Player2 : Entity
    {

        //Creates an Entity at the specified coordinates
        public Player2() : base(0, 0)
        {

        }
        public override void Update(float deltaTime)
        {
            //Checks for collison with Player1
            Program.Player2HitBox.DetectCollision(Program.Player1HitBox);

            //Moves the player up
            if (Input.IsKeyDown(325))//up arrow
            {
                Y -= 200f * deltaTime;
            }
            //Moves the player down
            if (Input.IsKeyDown(322))//down arrow
            {
                Y += 200f * deltaTime;
            }
            base.Update(deltaTime);
        }
    }
}

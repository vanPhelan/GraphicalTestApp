using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Player : Entity
    {
        //Creates an Entity at the specified coordinates
        public Player() : base (0,0)
        {
            
        }

        public override void Update(float deltaTime)
        {
            //Checking for collison with player2
            Program.Player1HitBox.DetectCollision(Program.Player2HitBox);
            
            //Moves the Player up
            if (Input.IsKeyDown(87)) // W
            {
                Y -= 200f * deltaTime;
            }

            //Moves the Player down
            if (Input.IsKeyDown(83))//S
            {
                Y += 200f * deltaTime;
            }
            base.Update(deltaTime);
        }
    }
}


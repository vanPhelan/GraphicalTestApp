﻿using System;
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
            Program.box.DetectCollision(Program.box3);
            Program.box2.DetectCollision(Program.box4);
            Program.box3.DetectCollision(Program.box);
            Program.box4.DetectCollision(Program.box2);

            if (Input.IsKeyDown(87))
            {
                Y -= 200f * deltaTime;
            }
            if (Input.IsKeyDown(83))
            {
                Y += 200f * deltaTime;
            }
            //## Calculate velocity from acceleration ##//
            //## Calculate position from velocity ##//
            base.Update(deltaTime);
        }
    }
}


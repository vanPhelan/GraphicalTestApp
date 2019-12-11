using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Program
    {
        //Player1 Game Objects 
        public static HiddenPlayerBox Player1 = new HiddenPlayerBox(640, 180);

        public static Player TankBase = new Player();
        public static Cannon cannon = new Cannon();
        //Player1 HitBox
        public static AABB Player1HitBox = new AABB(60, 60);

        //Player2 Game Objects
        public static HiddenPlayerBox2 Player2 = new HiddenPlayerBox2(640, 580);
        
        public static Player2 TankBase2 = new Player2();
        public static Cannon2 cannon2 = new Cannon2();
        //Player2 HitBox
        public static AABB Player2HitBox = new AABB(60, 60);


        static void Main(string[] args)
        {
            //Creates the window and the room of the game
            Game game = new Game(1280, 760, "Graphical Test Application");

            Actor root = new Actor();
            game.Root = root;
            
            //Player 1 Sprites
            Sprite tankBaseImage = new Sprite("Images/GreenTank.png");
            Sprite cannonImage = new Sprite("Images/GreenBarrel.png");

            //Offsets the cannon image
            cannonImage.Y += 10;

            //rotates the sprite image
            TankBase.Rotate((float)Math.PI);

            //Adds player 1 to the Scene
            root.AddChild(Player1);
            
            Player1.AddChild(TankBase);

            TankBase.AddChild(tankBaseImage);
            TankBase.AddChild(Player1HitBox);
            TankBase.AddChild(cannon);

            cannon.AddChild(cannonImage);

            //Player 2 Sprites
            Sprite cannonImage2 = new Sprite("Images/RedBarrel.png");
            Sprite tankBaseImage2 = new Sprite("Images/RedTank.png");

            //Offsets the cannon image
            cannonImage2.Y += 10;

            //rotates the sprite image
            TankBase2.Rotate((float)Math.PI);

            //Adds player 2 to the Scene
            root.AddChild(Player2);

            Player2.AddChild(TankBase2);

            TankBase2.AddChild(tankBaseImage2);
            TankBase2.AddChild(Player2HitBox);
            TankBase2.AddChild(cannon2);

            cannon2.AddChild(cannonImage2);

            //runs the game
            game.Run();
        }
    }
}

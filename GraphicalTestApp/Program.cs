using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Program
    {
        public static HiddenPlayerBox GameEmpty = new HiddenPlayerBox(640, 180);

        public static Player TankBase = new Player();
        public static Cannon cannon = new Cannon();

        public static AABB box2 = new AABB(100, 100);
        public static AABB box = new AABB(64, 64);

        public static HiddenPlayerBox2 GameEmpty2 = new HiddenPlayerBox2(640, 580);
        
        public static Player2 TankBase2 = new Player2();
        public static Cannon2 cannon2 = new Cannon2();

        public static AABB box3 = new AABB(100, 100);
        public static AABB box4 = new AABB(64, 64);


        static void Main(string[] args)
        {
            Game game = new Game(1280, 760, "Graphical Test Application");

            Actor root = new Actor();
            game.Root = root;
            
            //player 1
            Sprite tankBaseImage = new Sprite("Images/GreenTank.png");
            Sprite cannonImage = new Sprite("Images/GreenBarrel.png");

            cannonImage.Y += 10;
            TankBase.Rotate((float)Math.PI);

            root.AddChild(GameEmpty);
            
            GameEmpty.AddChild(TankBase);

            TankBase.AddChild(tankBaseImage);
            TankBase.AddChild(box);
            TankBase.AddChild(cannon);

            cannon.AddChild(cannonImage);
            cannon.AddChild(box2);

            //player 2
            Sprite cannonImage2 = new Sprite("Images/RedBarrel.png");
            Sprite tankBaseImage2 = new Sprite("Images/RedTank.png");
            Sprite Bullet2 = new Sprite("Images/RedBullet.png");

            cannonImage2.Y += 10;
            TankBase2.Rotate((float)Math.PI);

            root.AddChild(GameEmpty2);

            GameEmpty2.AddChild(TankBase2);

            TankBase2.AddChild(tankBaseImage2);
            TankBase2.AddChild(box3);
            TankBase2.AddChild(cannon2);

            cannon2.AddChild(cannonImage2);
            cannon2.AddChild(box4);

            //## Set up game here ##//

            game.Run();
        }
        public Player GetPlayer()
        {
            return TankBase;
        }
        public Player2 GetPlayer2()
        {
            return TankBase2;
        }
        public HiddenPlayerBox GetHidden()
        {
            return GameEmpty;
        }
        public HiddenPlayerBox2 GetHidden2()
        {
            return GameEmpty2;
        }
    }
}

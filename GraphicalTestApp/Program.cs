using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Program
    {
        public static HiddenPlayerBox GameEmpty = new HiddenPlayerBox(640, 380);

        public static Cannon cannon = new Cannon();
        public static Player TankBase = new Player();

        public static HiddenPlayerBox GameEmpty2 = new HiddenPlayerBox(640, 380);

        public static Cannon cannon2 = new Cannon();
        public static Player2 TankBase2 = new Player2();


        static void Main(string[] args)
        {
            Game game = new Game(1280, 760, "Graphical Test Application");

            Actor root = new Actor();
            game.Root = root;

            
            //player 1
            AABB box2 = new AABB(200, 200);
            AABB box = new AABB(64,64);

            Sprite tankBaseImage = new Sprite("Images/TEST.png");
            Sprite cannonImage = new Sprite("Images/TEST.png");

            root.AddChild(GameEmpty);
            root.AddChild(GameEmpty2);


            GameEmpty.AddChild(TankBase);
            TankBase.AddChild(cannon);

            TankBase.AddChild(tankBaseImage);
            cannon.AddChild(cannonImage);

            TankBase.AddChild(box);
            cannon.AddChild(box2);

            //player 2


            GameEmpty2.AddChild(TankBase2);
            TankBase2.AddChild(cannon2);

            TankBase.AddChild(tankBaseImage);
            cannon.AddChild(cannonImage);

            TankBase.AddChild(box);
            cannon.AddChild(box2);

            //## Set up game here ##//

            game.Run();
        }
        public Player GetPlayer()
        {
            return TankBase;
        }
        public HiddenPlayerBox GetHidden()
        {
            return GameEmpty;
        }
    }
}

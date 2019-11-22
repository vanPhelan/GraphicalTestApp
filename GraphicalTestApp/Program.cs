using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(1280, 760, "Graphical Test Application");

            Actor root = new Actor();
            game.Root = root;

            Player TankBase = new Player(640, 380);
            Cannon cannon = new Cannon();
            

            AABB box2 = new AABB(200, 200);
            AABB box = new AABB(64,64);

            Sprite tankBaseImage = new Sprite("Images/TEST.png");
            Sprite cannonImage = new Sprite("Images/TEST.png");
            
            root.AddChild(TankBase);

            TankBase.AddChild(tankBaseImage);
            cannon.AddChild(cannonImage);

            TankBase.AddChild(cannon);

            TankBase.AddChild(box);
            cannon.AddChild(box2);

            //## Set up game here ##//

            game.Run();
        }
    }
}

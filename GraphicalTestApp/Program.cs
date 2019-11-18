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

            //Entity player = new Entity(640, 380);
            //AABB boc = new AABB(64, 64);

            //player.AddChild(boc);
            //root.AddChild(player);

            //## Set up game here ##//

            game.Run();
        }
    }
}

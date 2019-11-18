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

            Entity player = new Entity(640, 380);
            AABB box = new AABB(64, 64);

            Sprite testing = new Sprite("Images/TEST.png");
            
            
            root.AddChild(player);
            player.AddChild(testing);
            player.AddChild(box);
            
            //## Set up game here ##//

            game.Run();
        }
    }
}

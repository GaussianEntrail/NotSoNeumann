using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSoNeumann
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cellular automata program
            //Cells can be true (1) or false (0)
            //Uses a Von Neumann neighborhood so each cell has a North, East, West and South neighbor
            //these neighbors are expressed as a four bit number NEWS
            //a 16 bit "rule" is used to determine an output based on the 16 different possible neighborhoods
            Random r = new Random();
            ushort rule = (ushort) (r.Next() & 65535);
            NeumannNeumannAy game = new NeumannNeumannAy(rule, 48, 16, true);
            while (true)
            {
                game.draw();
                Console.ReadKey();
                game.update();
            }

        }
    }
}

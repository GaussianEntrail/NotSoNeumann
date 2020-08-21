using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSoNeumann
{

    class NeumannNeumannAy
    {
        ushort rule;
        int w;
        int h;
        int t;
        bool[,] grid;
        bool wrap;
        bool defaultValue;
        Random r;

        public NeumannNeumannAy(ushort rule, int w, int h, bool wrap = false, bool defaultValue = false)
        {

            this.rule = rule;
            this.w = w;
            this.h = h;
            this.wrap = wrap;
            this.defaultValue = defaultValue;

            r = new Random();
            t = 0;
            grid = new bool[h, w];
            randomFill();
        }
        void randomFill()
        {
            int y, x;
            for (y = 0; y < h; y++)
            {
                for (x = 0; x < w; x++)
                {
                    grid[y, x] = (r.NextDouble() > 0.5);
                }
            }
        }
        bool get(int x, int y)
        {
            int _x = x, _y = y;

            if (wrap)
            {
                _x = (x + w) % w;
                _y = (y + h) % h;
            }

            if (_x >= 0 && _x < w && _y >= 0 && _y < h)
            {
                return grid[_y, _x];
            }
            return defaultValue;
        }
        void set(int x, int y, bool k)
        {
            if (x >= 0 && x < w && y >= 0 && y < h)
            {
                grid[y, x] = k;
            }
        }
        int neighborhood(int x, int y)
        {
            int output = 0;
            if (get(x, y - 1)) { output |= 1 << 0; } //UP
            if (get(x - 1, y)) { output |= 1 << 1; } //LEFT
            if (get(x + 1, y)) { output |= 1 << 2; } //RIGHT
            if (get(x, y + 1)) { output |= 1 << 3; } //DOWN
            return output;
        }
        bool checkRule(int inputState)
        {
            return ((rule >> inputState) & 1) == 1;
        }
        public void update()
        {
            bool[,] newgrid = new bool[h, w];

            int y, x, n;
            for (y = 0; y < h; y++)
            {
                for(x = 0; x < w; x++)
                {
                    n = neighborhood(x, y);
                    newgrid[y, x] = checkRule(n);
                }
            }

            t++;
            this.grid = newgrid;
        }
        public void draw()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("PRESS ANY KEY TO ADVANCE THE CELLULAR AUTOMATA\n");
            Console.WriteLine("Rule: {0}\tStep: {1}", rule, t);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            int y, x;
            string bar = new string('═', w);
            Console.Write("╔");
            Console.Write(bar);
            Console.Write("╗\n");
            for (y = 0; y < h; y++)
            {
                Console.Write("║");
                for (x = 0; x < w; x++)
                {
                    if (grid[y, x]) { Console.BackgroundColor = ConsoleColor.Red; }
                    Console.Write(" ");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.Write("║\n");
            }
            Console.Write("╚");
            Console.Write(bar);
            Console.Write("╝\n");
        }

    }
}

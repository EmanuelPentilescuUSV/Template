using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Randomizer
    {
        private int move;
        private int coord;
        private Color color;
        private Random random;
        private int colorR, colorG, cologB;

        public Randomizer()
        {
            move = 0;
            coord = 0;
            random = new Random();
        }

        public Color generateColor()
        {
            colorR = random.Next(0, 256);
            colorG = random.Next(0, 256);
            cologB = random.Next(0, 256);
            color = Color.FromArgb(colorR, colorG, cologB);
            return color;
        }

        public int generateCoord()
        {
            coord = random.Next(0, 50);
            return coord;
        }

        public int generateMove()
        {
            move = random.Next(-50, 50);
            return move;
        }
    }
}

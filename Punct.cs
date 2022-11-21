using OpenTK.Graphics.OpenGL;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Punct
    {

        private List<int> coord = new List<int>();
        private List<Color> color = new List<Color>();
        private int counter;
        Randomizer random;
        public Punct(){ 
            counter = 0;
            random = new Randomizer();
            
        }

        public void generateDot()
        {
            coord.Add(random.generateCoord());
            color.Add(random.generateColor());
            counter++;
        }

        public void Draw()
        {
            GL.Begin(PrimitiveType.Points);
            for(int i=0;i<counter;i++)
            {
                GL.Color3(color[i]);
                GL.Vertex3(0, 1, coord[i]);
            }
            GL.End();
        }

        public void moveDots()
        {
            
            GL.PushMatrix();
            GL.PointSize(5);
            GL.Translate(0, 1, random.generateMove());
            Draw();
            GL.PopMatrix();
        }
    }
}

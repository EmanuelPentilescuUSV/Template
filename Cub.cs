using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Cub
    {
        private int transX;
        private int transY;
        private int transZ;
        private bool visibility;

        
        private int[,] objVertices = {
            {5, 10, 5,
                10, 5, 10,
                5, 10, 5,
                10, 5, 10,
                5, 5, 5,
                5, 5, 5,
                5, 10, 5,
                10, 10, 5,
                10, 10, 10,
                10, 10, 10,
                5, 10, 5,
                10, 10, 5},
            {5, 5, 12,
                5, 12, 12,
                5, 5, 5,
                5, 5, 5,
                5, 12, 5,
                12, 5, 12,
                12, 12, 12,
                12, 12, 12,
                5, 12, 5,
                12, 5, 12,
                5, 5, 12,
                5, 12, 12},
            {6, 6, 6,
                6, 6, 6,
                6, 6, 12,
                6, 12, 12,
                6, 6, 12,
                6, 12, 12,
                6, 6, 12,
                6, 12, 12,
                6, 6, 12,
                6, 12, 12,
                12, 12, 12,
                12, 12, 12}};

        public Cub()
        {
            visibility = true;
            transX = 0;
            transY = 0;
            transZ = 0;
        }

        public void Draw()
        {
            GL.Begin(PrimitiveType.Triangles);
            for (int i = 0; i < 35; i = i + 3)
            {
                GL.Color3(Color.Red);
                GL.Vertex3(objVertices[0,i],objVertices[1,i],objVertices[2,i]);
                GL.Vertex3(objVertices[0, i+1], objVertices[1, i+1], objVertices[2, i+1]);
                GL.Vertex3(objVertices[0, i+2], objVertices[1, i+2], objVertices[2, i+2]);
            }
            GL.End();
        }

        public double getTransX()
        {
            return transX;
        }
        public int  getTransY()
        {
            return transY;
        }
        public int getTransZ ()
        {
            return transZ;
        }

        public void Move()
        {
            transX++;
        }
    }
}

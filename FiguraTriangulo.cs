using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Curso_C_Sharp
{
    class FiguraTriangulo : FiguraRectangulo
    {
        public void Area(int Base, int Altura)
        {
            Console.WriteLine("El area del triangulo es: " + (Base * Altura) / 2);
        }
    }
}

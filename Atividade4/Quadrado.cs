using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4
{
    public class Quadrado : Forma
    {
        public override void CalcularArea(double valor)
        {
            double area = valor * valor;
            Console.WriteLine($"A aréa do quadrado é {area}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4
{
    public class Circulo : Forma
    {
        public override void CalcularArea(double valor)
        {
            double area = 3.14 * (valor * valor);
            Console.WriteLine($"A aréa do circulo é {area}");
        }
    }
}

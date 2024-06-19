using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6
{
    public class Piano:InstrumentoMusical
    {
        public override void Tocar()
        {
            Console.WriteLine("Barulho de Piano");
        }
    }
}

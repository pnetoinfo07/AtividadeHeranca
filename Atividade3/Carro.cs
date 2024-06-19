using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    public class Carro : Veiculo
    {
        public int NumeroPortas { get; set; }
        public Carro(string marca, string modelo, int numeroPortas)
            : base(marca, modelo)
        {
            NumeroPortas = numeroPortas;
        }
    }
}

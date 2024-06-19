using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeHeranca
{
    public class Animal
    {
        public virtual void Falar()
        {
            Console.WriteLine("Som de animal!!");
        }
    }
}

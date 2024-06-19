using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade5
{
    public class Gerente : Funcionario
    {
        public Gerente(double salario)
            : base(salario)
        {
            Salario = salario;
        }
        public override void CalcularSalario()
        {
            Salario = Salario + (Salario * 0.4);
            Console.WriteLine($"Seu salario é {Salario}");
        }
    }
    
}

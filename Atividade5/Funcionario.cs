using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade5
{
    public class Funcionario
    {
        public double Salario { get; set; }
        public Funcionario(double salario)
        {
            Salario= salario;
        }
        public virtual void CalcularSalario()
        {
            Salario = Salario + (Salario * 0.2);
            Console.WriteLine($"Seu salario é {Salario}");
        }
    }
}

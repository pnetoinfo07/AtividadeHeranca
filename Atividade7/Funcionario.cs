using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade7
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Funcionario(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}

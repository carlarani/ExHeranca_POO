using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeranca_POO
{
    class Telefonista : Funcionario
    {
        public Telefonista(string nome, double salario) : base(nome, salario)
        {
        }

        public int estacaoDeTrabalho;
    }
}

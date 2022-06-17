using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeranca_POO
{
    class Secretaria : Funcionario
    {
        public Secretaria(string nome, double salario, int ramal) : base(nome, salario)
        {
            this.ramal = ramal;
        }

        public int ramal;

        public override void imprimirDados(Funcionario funcionario)
        {
            Console.WriteLine($"O salário de {funcionario.Nome}, que opera no ramal {ramal}, era R${Math.Round(funcionario.Salario, 2)}. Após a bonificação ficou R${Math.Round(funcionario.calcularBonificacao(funcionario.Salario), 2)}.");
            Console.WriteLine(Environment.NewLine);
        }
    }
}

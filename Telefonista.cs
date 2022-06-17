using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeranca_POO
{
    class Telefonista : Funcionario
    {
        public Telefonista(string nome, double salario, int estacaoDeTrabalho) : base(nome, salario)
        {
            this.estacaoDeTrabalho = estacaoDeTrabalho;
        }

        public int estacaoDeTrabalho;

        public override void imprimirDados(Funcionario funcionario)
        {
            Console.WriteLine($"O salário de {funcionario.Nome}, que trabalha na estação {estacaoDeTrabalho}, era R${Math.Round(funcionario.Salario, 2)}. Após a bonificação ficou R${Math.Round(funcionario.calcularBonificacao(funcionario.Salario), 2)}.");
            Console.WriteLine(Environment.NewLine);
        }
    }
}

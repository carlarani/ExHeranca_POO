using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeranca_POO
{
    class Gerente : Funcionario
    {
        public Gerente(string nome, double salario, string nomeDeUsuario, string senha) : base(nome, salario)
        {
            this.nomeDeUsuario = nomeDeUsuario;
            this.senha = senha;
        }

        private string nomeDeUsuario;
        public string NomeDeUsuario
        {
            get { return nomeDeUsuario; }
            set { nomeDeUsuario = value; }
        }

        private string senha;
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public override double calcularBonificacao(double Salario)
        {
            Salario = Salario * 1.5;
            return Salario;
        }

        public override void imprimirDados(Funcionario funcionario)
        {
            Console.WriteLine($"O salário de {funcionario.Nome} era R${Math.Round(funcionario.Salario, 2)}. Após a bonificação exclusiva de gerentes ficou R${Math.Round(funcionario.calcularBonificacao(funcionario.Salario), 2)}.");
            Console.WriteLine($"Para maior detalhes, acesse a intranet atraves do seu login:{NomeDeUsuario}.");
            Console.WriteLine(Environment.NewLine);
        }
    }
}

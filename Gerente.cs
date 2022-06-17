using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeranca_POO
{
    class Gerente : Funcionario
    {
        public Gerente(string nome, double salario) : base(nome, salario)
        {
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
    }
}

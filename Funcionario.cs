using System;

namespace ExHeranca_POO
{
    public class Funcionario
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private double salario;
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public Funcionario(string nome, double salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public virtual double calcularBonificacao(double Salario)
        {
            Salario = Salario * 1.1;
            return Salario;
        }

        public virtual void imprimirDados(Funcionario funcionario)
        {
            Console.WriteLine($"O salário de {funcionario.Nome} era R${Math.Round(funcionario.Salario, 2)}. Após a bonificação ficou R${Math.Round(funcionario.calcularBonificacao(funcionario.Salario), 2)}.");
            Console.WriteLine(Environment.NewLine);
        }
    }
    
    
    class TesteFuncionario
    {
        static void Main(string[] args)
        {
            Funcionario func01 = new Funcionario("Douglas", 2000);
            Funcionario func02 = new Gerente("Daniel", 4000, "daniel2022", "123456789abc");
            Funcionario func03 = new Telefonista("Denise", 7000, 68845);
            Funcionario func04 = new Secretaria("Diana", 4500, 8081);
            Funcionario func05 = new Funcionario("Duke", 3800);
            Funcionario func06 = new Gerente("Fernanda", 10000, "fernanda001", "fernandinha1234");
            Funcionario func07 = new Telefonista("Fabiano", 2000, 24568);
            Funcionario func08 = new Secretaria("Fuller", 4500, 2524);

            func01.imprimirDados(func01);
            func02.imprimirDados(func02);
            func03.imprimirDados(func03);
            func04.imprimirDados(func04);
            func05.imprimirDados(func05);
            func06.imprimirDados(func06);
            func07.imprimirDados(func07);
            func08.imprimirDados(func08);


        }
    }
}
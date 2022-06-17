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

        public static void imprimirDados(Funcionario funcionario)
        {
            Console.WriteLine($"O salário de {funcionario.Nome} é R${Math.Round(funcionario.Salario, 2)}");
            Console.WriteLine($"Após bonificação, o salário de {funcionario.Nome} passou para R${Math.Round(funcionario.calcularBonificacao(funcionario.Salario), 2)}");
            Console.WriteLine(Environment.NewLine);        
        }
    }
    
    
    class TesteFuncionario
    {
        static void Main(string[] args)
        {
            Funcionario func01 = new Funcionario("Douglas", 2000);
            Funcionario func02 = new Funcionario("Daniel", 4000);
            Funcionario func03 = new Funcionario("Denise", 7000);
            Funcionario func04 = new Funcionario("Diana", 4500);
            Funcionario func05 = new Funcionario("Duke", 3800);
            Funcionario func06 = new Gerente("Fernanda", 10000);
            Funcionario func07 = new Telefonista("Fabiano", 2000);
            Funcionario func08 = new Secretaria("Fuller", 4500);

            Funcionario.imprimirDados(func01);
            Funcionario.imprimirDados(func02);
            Funcionario.imprimirDados(func03);
            Funcionario.imprimirDados(func04);
            Funcionario.imprimirDados(func05);
            Funcionario.imprimirDados(func06);
            Funcionario.imprimirDados(func07);
            Funcionario.imprimirDados(func08);


        }
    }
}
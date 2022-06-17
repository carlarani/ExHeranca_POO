﻿using System;

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


            Console.WriteLine($"O salário de {func01.Nome} é R${func01.Salario}");
            Console.WriteLine($"O salário de {func02.Nome} é R${func02.Salario}");
            Console.WriteLine($"O salário de {func03.Nome} é R${func03.Salario}");
            Console.WriteLine($"O salário de {func04.Nome} é R${func04.Salario}");
            Console.WriteLine($"O salário de {func05.Nome} é R${func05.Salario}");
        }
    }
}
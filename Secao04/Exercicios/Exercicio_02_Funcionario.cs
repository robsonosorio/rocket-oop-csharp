using System;

namespace Secao04.Exercicios
{
    public class Exercicio_02_Funcionario
    {
        public string Nome2;
        public double Salario;

        public void Exercicio()
        {
            Console.Clear();

            var pessoa1 = new Exercicio_02_Funcionario();
            Console.WriteLine("Dados do primeiro funcionário");
            Console.Write("Nome: ");
            pessoa1.Nome2 = Console.ReadLine();
            Console.Write("Salário: R$ ");
            pessoa1.Salario = int.Parse(Console.ReadLine());

            var pessoa2 = new Exercicio_02_Funcionario();
            Console.WriteLine("\nDados do segundo funcionário");
            Console.Write("Nome: ");
            pessoa2.Nome2 = Console.ReadLine();
            Console.Write("Salário: R$ ");
            pessoa2.Salario = int.Parse(Console.ReadLine());

            double salarioMedio = (pessoa1.Salario + pessoa2.Salario) / 2.0;
            Console.Write("\nSalário Médio dos funcionários: R$ " + salarioMedio);
        }
    }
}

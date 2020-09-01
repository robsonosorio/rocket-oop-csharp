using System;
using System.Globalization;

namespace Secao04.Exercicios
{
    public class Exercicio_05_Funcionario_Salario
    {
        public string Nome5;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalrio(double porcentagem)
        {
            SalarioBruto = SalarioBruto - Imposto + (SalarioBruto * (porcentagem / 100.0));
        }

        public void Exercicio()
        {
            Console.Clear();

            var salarioFuncionario = new Exercicio_05_Funcionario_Salario();
            Console.WriteLine("Digite os dados do funcionário\n");
            Console.Write("Nome: ");
            salarioFuncionario.Nome5 = Console.ReadLine();
            Console.Write("Salário bruto: R$ ");
            salarioFuncionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: R$ ");
            salarioFuncionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nFuncionário: " + salarioFuncionario.Nome5 + ", R$ " + salarioFuncionario.SalarioLiquido());

            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            double aumenta = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salarioFuncionario.AumentarSalrio(aumenta);

            Console.Write("\nDados atualizados: " + salarioFuncionario.Nome5 + ", R$ " + salarioFuncionario.SalarioBruto);
        }
    }
}

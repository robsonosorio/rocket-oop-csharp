using Secao09.Exercicios.Exercicio_01.Entities;
using Secao09.Exercicios.Exercicio_01.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Secao09.Exercicios
{
    public class Exercicio_01_Composicao
    {
        public void Exercicio()
        {
            Console.Clear();

            Console.Write("Entre com o nome do Departamento: ");
            string depto = Console.ReadLine();
            Console.WriteLine("\nDados do colaborador:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Level: (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salario base do colaborador: ");
            double baseSalarial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department departamento = new Department(depto);
            Worker colaborador = new Worker(nome, level, baseSalarial, departamento);

            Console.Write("\nInsira o número de contratos para este trabalhador: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine($"]nDigite os dados do contrato 0{i} :");
                Console.Write("Data (DD/MM/AAAA): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor da hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Horas trabalhadas: ");
                int horas = int.Parse(Console.ReadLine());
                HourContract contrato = new HourContract(data, valorPorHora, horas);
                colaborador.AddContract(contrato);
            }

            Console.Write("\nDigite o mês e o ano, para obter a receita do colaborador (MM/AAAA): ");
            string mesEAno = Console.ReadLine();
            int mes = int.Parse(mesEAno.Substring(0, 2));
            int ano = int.Parse(mesEAno.Substring(3));
            Console.WriteLine("Nome : " + colaborador.Name);
            Console.WriteLine("Departamento: " + colaborador.Department.Name);
            Console.WriteLine("Receita para " + mesEAno + ": " + colaborador.Income(ano, mes).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

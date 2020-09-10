using Secao10.Exercicios.Exercicio_01_Heranca.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Secao10.Exercicios.Exercicio_01_Heranca
{
    public class Exercicio_01_Heranca
    {
        public List<Employee> funcionarios = new List<Employee>();
        public void Exercicio()
        {
            Console.Clear();

            Console.Write("Digite o número de funcionários: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine("\nDados do funcionário 0{0}", i);
                Console.Write("Outsourced (s/n)? ");
                char decisao = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valor = double.Parse(Console.ReadLine());
                
                if (decisao == 's' || decisao == 'S')
                {
                    Console.Write("Despesa Adicional: ");
                    double adicional = double.Parse(Console.ReadLine());
                    funcionarios.Add(new OutsourcedEmployee(nome, horas, valor, adicional));
                }
                else
                {
                    funcionarios.Add(new Employee(nome, horas, valor));
                }
            }

            Console.WriteLine("`\n## PAGAMENTOS ##");
            foreach (var func in funcionarios)
            {
                Console.WriteLine(func.Name + " | R$ " + func.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

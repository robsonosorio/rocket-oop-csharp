using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Secao06.Exercicios
{
    public class Exercicio_04_RegistroFuncionarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Exercicio_04_RegistroFuncionarios()
        {
        }

        public Exercicio_04_RegistroFuncionarios(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void Aumento(double porcentagem)
        {
            Salario += Salario * porcentagem / 100;
        }

        public override string ToString()
        {
            return "ID " + Id
                + " | Nome " + Nome
                + " | Salário R$ " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void Exercicio()
        {
            Console.Clear();

            Console.Write("Registro de funcionários !\n");
            Console.Write("Número de funcionário à registrar: ");
            int numero = int.Parse(Console.ReadLine());

            var listaFuncionarios = new List<Exercicio_04_RegistroFuncionarios>();

            for (int i=1; i <= numero; i++)
            {
                Console.WriteLine("\nNome do Funcionário 0{0}: ", i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listaFuncionarios.Add(new Exercicio_04_RegistroFuncionarios(id, nome, salario));
            }
            Console.WriteLine("\nLista de funcionários:");
            foreach (var obj in listaFuncionarios)
            {
                Console.WriteLine(obj);
            }

            Console.Write("\nDigite a ID do funcionário que irá ganhar aumento: ");
            int consulta = int.Parse(Console.ReadLine());

            var funcionario = listaFuncionarios.Find(x => x.Id == consulta);
            if (funcionario != null)
            {
                Console.Write("Digite a porcentagem de aumento: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionario.Aumento(porcentagem);
            }
            else
            {
                Console.WriteLine("\nNão existe funcionário para esse ID");
            }

            Console.WriteLine("\nLista de funcionários atualizada:");
            foreach (var func in listaFuncionarios)
            {
                Console.WriteLine(func);
            }
        }
    }
}

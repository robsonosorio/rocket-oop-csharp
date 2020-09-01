using System;
using System.Threading;
using Secao04.Exercicios;

namespace Secao04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### RESOLUÇÃO EXERCÍCIOS ###\n");

            int decisao;
            do
            {
                Console.Clear();
                Console.WriteLine("             [MENU]  ");
                Console.WriteLine("   1 - Exercicio 01    ");
                Console.WriteLine("   2 - Exercicio 02    ");
                Console.WriteLine("   3 - Exercicio 03    ");
                Console.WriteLine("   4 - Exercicio 04    ");
                Console.WriteLine("   5 - Exercicio 05    ");
                Console.WriteLine("   6 - Exercicio 06    ");
                Console.WriteLine("   7 - Exercicio 07    ");
                Console.WriteLine("   8 - Exercicio 08    ");
                Console.WriteLine("   0 - Sair            ");
                Console.Write("[Escolha um exercício] ");
                decisao = int.Parse(Console.ReadLine());

                switch (decisao)
                {
                    case 1:
                        var ex1 = new Exercicio_01_Pessoa();
                        ex1.Exercicio();
                        Console.ReadKey();
                        break;
                    case 2:
                        var ex2 = new Exercicio_02_Funcionario();
                        ex2.Exercicio();
                        Console.ReadKey();
                        break;
                    case 3:
                        var ex3 = new Exercicio_03_Produto();
                        ex3.Exercicio();
                        Console.ReadKey();
                        break;
                    case 4:
                        var ex4 = new Exercicio_04_Retangulo();
                        ex4.Exercicio();
                        Console.ReadKey();
                        break;
                    case 5:
                        var ex5 = new Exercicio_05_Funcionario_Salario();
                        ex5.Exercicio();
                        Console.ReadKey();
                        break;
                    case 6:
                        var ex6 = new Exercicio_06_Aluno();
                        ex6.Exercicio();
                        Console.ReadKey();
                        break;
                    case 7:
                        var ex7 = new Exercicio_07_Calculadora();
                        ex7.Exercicio();
                        Console.ReadKey();
                        break;
                        case 8:
                        var ex8 = new Exercicio_08_Dolar();
                        ex8.Exercicio();
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.WriteLine("Até logo !");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine(" '{0}' não é válido.Tente novamente.", decisao);
                        Console.ReadKey();
                        break;
                }
            } while (decisao != 0);
        }
    }
}

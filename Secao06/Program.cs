using Secao06.Exercicios;
using System;

namespace Secao06
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
                Console.WriteLine("   0 - Sair            ");
                Console.Write("[Escolha um exercício] ");
                decisao = int.Parse(Console.ReadLine());

                switch (decisao)
                {
                    case 1:
                        var ex1 = new Exercicio_01();
                        ex1.Exercicio();
                        Console.ReadKey();
                        break;
                    case 2:
                        var ex2 = new Exercicio_02_Produto();
                        ex2.Exercicio();
                        Console.ReadKey();
                        break;
                    case 3:
                        var ex3 = new Exercicio_03_Estudante();
                        ex3.Exercicio();
                        Console.ReadKey();
                        break;
                    case 4:
                        var ex4 = new Exercicio_04_RegistroFuncionarios();
                        ex4.Exercicio();
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

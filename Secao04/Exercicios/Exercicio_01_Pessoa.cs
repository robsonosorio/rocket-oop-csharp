using System;

namespace Secao04.Exercicios
{
    public class Exercicio_01_Pessoa
    {
        public string Nome1;
        public int Idade;

        public void Exercicio()
        {
            Console.Clear();

            var pessoa1 = new Exercicio_01_Pessoa();
            Console.WriteLine("Dados da primeira pessoa\n");
            Console.Write("Nome: ");
            pessoa1.Nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            var pessoa2 = new Exercicio_01_Pessoa();
            Console.WriteLine("\nDados da segunda pessoa");
            Console.Write("Nome: ");
            pessoa2.Nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.Write("\nPessoa mais velha: " + pessoa1.Nome1);
            }
            else
            {
                Console.Write("\nPessoa mais velha: " + pessoa2.Nome1);
            }
        }
    }
}

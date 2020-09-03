using System;

namespace Secao06.Exercicios
{
    public class Exercicio_03_Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Exercicio_03_Estudante()
        {
        }

        public Exercicio_03_Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + " | Email: " + Email;
        }

        public void Exercicio()
        {
            Console.Clear();

            var vetor = new Exercicio_03_Estudante[10];
            Console.WriteLine("Aluguel de quartos para estudantes");
            Console.Write("\nEntre com número de estudantes: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine("\nAluguel 0{0}:", i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vetor[quarto] = new Exercicio_03_Estudante(nome, email);
            }

            Console.WriteLine("\nRelatório de quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] != null)
                {
                    Console.WriteLine("Quarto: 0" + i + " | " + vetor[i]);
                }
            }
        }
    }
}

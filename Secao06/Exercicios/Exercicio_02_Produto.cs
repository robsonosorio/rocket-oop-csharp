using System;
using System.Globalization;

namespace Secao06.Exercicios
{
    public class Exercicio_02_Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public void Exercicio ()
        {
            Console.Clear();

            Console.WriteLine("Preço médio de produtos");
            Console.Write("\nQuantidade de produtos: ");
            int numero = int.Parse(Console.ReadLine());

            var vetor = new Exercicio_02_Produto[numero];

            for (int i=0; i<numero; i++)
            {
                Console.Write("\nNome do produto {0}: ", i+1);
                string nome = Console.ReadLine();
                Console.Write("Preço do produto {0}: R$ ", i+1);
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vetor[i] = new Exercicio_02_Produto { Nome = nome, Preco = preco };
            }

            double soma = 0;
            for (int i=0; i<numero; i++)
            {
                soma += vetor[i].Preco;
            }

            double media = (soma / numero);
            Console.WriteLine("\nMédia de preço: R$" + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

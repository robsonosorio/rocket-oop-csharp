using System;
using System.Globalization;
using System.Numerics;

namespace Secao06.Exercicios
{
    public class Exercicio_01
    {
        public void Exercicio()
        {
            Console.Clear();

            Console.WriteLine("Calcular média das pessoas!\n");
            Console.Write("Adicionar número de pessoas: ");
            int numero = int.Parse(Console.ReadLine());

            double[] vetor = new double[numero];

            for (int i=0; i<numero; i++)
            {
                Console.Write("Digite altura da pessoa {0}: ", i+1);
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double soma = 0;
            for (int i=0; i<numero; i++)
            {
                soma += vetor[i];
            }

            double media = (soma / numero);
            Console.WriteLine("\nMédia de altura: " + media.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}

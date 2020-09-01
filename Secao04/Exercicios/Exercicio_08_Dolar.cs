using System;
using System.Globalization;

namespace Secao04.Exercicios
{
    class Exercicio_08_Dolar
    {
        public static double Iof = 6.0;
        public static double ConverteDorlarParaReal(double quantidade, double cotacao)
        {
            double total = quantidade * cotacao;
            return total + total * Iof / 100.0;
        }
        public void Exercicio()
        {
            Console.Clear();

            Console.Write("Qual cotação do dolar? $ ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantia à comprar, em dolar? $ ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double resultado = Exercicio_08_Dolar.ConverteDorlarParaReal(quantidade, cotacao);
            Console.WriteLine("\nTotal à pagar em reais, R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Obs: adicionado Iof de 6%");
        }
    }
}

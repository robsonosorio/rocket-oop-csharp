using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Secao02.Exercicios
{
    public class Exercicio_07_Calculadora
    {
        public static double Pi = 3.14;
        
        public static double Circunferencia(double r)
        {
            return 2 * Pi * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }

        public void Exercicio()
        {
            Console.Clear();

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Exercicio_07_Calculadora.Circunferencia(raio);
            double volume = Exercicio_07_Calculadora.Volume(raio);

            Console.WriteLine("\nCircuferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Exercicio_07_Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

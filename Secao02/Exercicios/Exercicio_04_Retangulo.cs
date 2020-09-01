using System;

namespace Secao02.Exercicios
{
    public class Exercicio_04_Retangulo
    {
        public double Largura;
        public double Altura;
        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return ( 2 * Largura) + ( 2 * Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }

        public void Exercicio()
        {
            Console.Clear();

            var retangulo = new Exercicio_04_Retangulo();
            Console.Write("Digite a largura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura do retângulo: ");
            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Area = " + retangulo.Area() + "\nPerímetro = " + retangulo.Perimetro() + "\nDiagonal = " + retangulo.Diagonal());
        }
    }
}

using System;

namespace Secao02.Exercicios
{
    public class Exercicio_06_Aluno
    {
        public string Nome6;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return (Nota1 + Nota2 + Nota3);
        }
        public double ParaSerAprovado()
        {
            return 60 - (Nota1 + Nota2 + Nota3);
        }

        public void Exercicio()
        {
            Console.Clear();

            var aluno = new Exercicio_06_Aluno();
            Console.Write("Nome do aluno: ");
            aluno.Nome6 = Console.ReadLine();
            Console.WriteLine("\nDigite as notas de {0}: ", aluno.Nome6);
            Console.Write("Nota primeiro trimeste (máx. 30.0 pontos): ");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            Console.Write("Nota segundo trimeste (máx. 35.0 pontos): ");
            aluno.Nota2 = double.Parse(Console.ReadLine());
            Console.Write("Nota terceiro trimeste (máx. 35.0 pontos): ");
            aluno.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nNota final de {0}: {1}", aluno.Nome6, aluno.NotaFinal());
            if (aluno.NotaFinal() >= 60)
            {
                Console.WriteLine("[ALUNO APROVADO]");
            }
            else
            {
                Console.WriteLine("[ALUNO REPROVADO]");
                Console.WriteLine("Faltaram {0} pontos para aprovação de {1}!", aluno.ParaSerAprovado(), aluno.Nome6);
            }
        }
    }
}

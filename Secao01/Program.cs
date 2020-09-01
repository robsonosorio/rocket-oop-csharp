using System;

namespace Secao01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### RESOLUÇÃO PROVA DE LOGICA ###\n");

            int decisao;
            do
            {
                Console.Clear();
                Console.WriteLine("             [MENU]  ");
                Console.WriteLine("   1 - Estrutura Sequencial  - Exercicio 01    ");
                Console.WriteLine("   2 - Estrutura Sequencial  - Exercicio 02    ");
                Console.WriteLine("   3 - Estrutura Condicional - Exercicio 01    ");
                Console.WriteLine("   4 - Estrutura Condicional - Exercicio 02    ");
                Console.WriteLine("   5 - Estrutura Repetitivas - Exercicio 01    ");
                Console.WriteLine("   6 - Estrutura Repetitivas - Exercicio 02    ");
                Console.WriteLine("   0 - Sair                  ");
                Console.Write("[Escolha um exercício] ");
                decisao = int.Parse(Console.ReadLine());

                switch (decisao)
                {
                    case 1:
                        Exercicio_1_1();
                        Console.ReadKey();
                        break;
                    case 2:
                        Exercicio_1_2();
                        Console.ReadKey();
                        break;
                    case 3:
                        Exercicio_2_1();
                        Console.ReadKey();
                        break;
                    case 4:
                        Exercicio_2_2();
                        Console.ReadKey();
                        break;
                    case 5:
                        Exercicio_3_1();
                        Console.ReadKey();
                        break;
                    case 6:
                        Exercicio_3_2();
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

        static void Exercicio_1_1()
        {
            Console.Clear();
            Console.WriteLine("\n### ESTRUTURA SEQUENCIAL ###\n");
            Console.Write("Insira código da peça 1: ");
            int peca1 = int.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int quantPeca1 = int.Parse(Console.ReadLine());
            Console.Write("Valor unitário da peça 1: R$ ");
            float valorPeca1 = float.Parse(Console.ReadLine());
            Console.Write("\nInsira código da peça 2: ");
            int peca2 = int.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int quantPeca2 = int.Parse(Console.ReadLine());
            Console.Write("Valor unitário da peça 2: R$ ");
            float valorPeca2 = float.Parse(Console.ReadLine());

            float valorTotal = (quantPeca1 * valorPeca1) + (quantPeca2 * valorPeca2);

            Console.WriteLine("\nCódigo da peça: " + peca1 + " | Quantidade: " + quantPeca1 + " | Valor (und.): R$ " + valorPeca1);
            Console.WriteLine("Código da peça: " + peca2 + " | Quantidade: " + quantPeca2 + " | Valor (und.): R$ " + valorPeca2);
            Console.Write("\nVALOR A PAGAR: R$ " + valorTotal);
        }

        static void Exercicio_1_2()
        {
            Console.Clear();
            Console.WriteLine("\n### ESTRUTURA SEQUENCIAL ###\n");
            Console.Write("Digite valor do raio de um circulo: ");
            double raio = double.Parse(Console.ReadLine());

            double areaCirculo = (3.14159) * (raio * raio);

            Console.Write("\n[Área do circulo] : " + areaCirculo);
        }

        static void Exercicio_2_1()
        {
            Console.Clear();
            Console.WriteLine("\n### ESTRUTURA CONDICIONAL ###\n" +
            "        ####### MENU #######\n" +
            "Cód. 1 -  Cachorro Quente - R$ 4,00\n" +
            "Cód. 2 -  X-Salada        - R$ 4,50\n" +
            "Cód. 3 -  X-Bacon         - R$ 5,00\n" +
            "Cód. 4 -  Torrada Simples - R$ 2,00\n" +
            "Cód. 5 -  Refrigerante    - R$ 1,50\n");

            float preco = 0;
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
            if (codigo == 1)
            {
                preco = 4.00f;
            }
            else if (codigo == 2)
            {
                preco = 4.50f;
            }
            else if (codigo == 3)
            {
                preco = 5.00f;
            }
            else if (codigo == 4)
            {
                preco = 2.00f;
            }
            else if (codigo == 5)
            {
                preco = 1.50f;
            }
            else
            {
                Console.Write("Item não registrado!");
            }

            float valorTotal = quantidade * preco;

            Console.Write("\nVALOR TOTAL: R$ " + valorTotal);
        }   

        static void Exercicio_2_2()
        {
            Console.Clear();
            Console.WriteLine("\n### ESTRUTURA CONDICIONAL ###\n");
            Console.WriteLine("Resolvendo Equação de segundo grau\n");
            Console.Write("Digite valor de 'a' : ");
            double valorA = double.Parse(Console.ReadLine());
            Console.Write("Digite valor de 'b' : ");
            double valorB = double.Parse(Console.ReadLine());
            Console.Write("Digite valor de 'c' : ");
            double valorC = double.Parse(Console.ReadLine());

            double delta = 0;
            if (valorA == 0)
            {
                Console.Write("\nImpossível calcular! Valor de 'a' não pode ser zero!");
            }
            else
            {
                delta = (valorB * valorB) - (4 * valorA * valorC);
                if (delta < 0)
                {
                    Console.Write("\nImpossível calcular! Valor de Delta não pode ser negativo!");
                }
                else
                {
                    double valorX1 = (-(valorB) + Math.Sqrt(delta)) / (2 * valorA);
                    double valorX2 = (-(valorB) - Math.Sqrt(delta)) / (2 * valorA);

                    Console.Write("\nX1 = " + valorX1 + "\nX2 = " + valorX2);
                }
            }
        }

        static void Exercicio_3_1()
        {
            Console.Clear();
            Console.WriteLine("\n### ESTRUTURAS REPETITIVAS ###\n");
            Console.WriteLine("dica: senha '2002' ");

            int senha = 2002;
            int entradaSenha = 0;
            do
            {
                Console.Write("\nDigite senha (4 dígitos): ");
                entradaSenha = int.Parse(Console.ReadLine());
                if (entradaSenha != senha)
                    Console.Write("\n[Acesso negado]  Senha inválida !\n");
            } while (entradaSenha != senha);

            Console.Write("\n[Acesso permitido]\n");
            Console.ReadKey();
        }

        static void Exercicio_3_2()
        {
            Console.Clear();
            Console.WriteLine("\n### ESTRUTURAS REPETITIVAS ###\n");
            Console.Write("Digite a quantidade de números que será inserida: ");
            int valorN = int.Parse(Console.ReadLine());
            int valorIn = 0;
            int valorOut = 0;
            for (int i = 0; i < valorN; i++)
            {
                Console.Write("\nDigite um valor inteiro: ");
                int valorX = int.Parse(Console.ReadLine());
                if (10 <= valorX && valorX <= 20)
                {
                    valorIn++;
                }
                else
                {
                    valorOut++;
                }
            }
            Console.Write("\nValores no intervalo [10,20]  \n" + valorIn + " DENTRO\n" + valorOut + " FORA");
        }
    }
}

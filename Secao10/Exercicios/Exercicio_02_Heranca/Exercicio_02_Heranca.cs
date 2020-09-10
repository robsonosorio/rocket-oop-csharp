using Secao10.Exercicios.Exercicio_02_Heranca.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Secao10.Exercicios.Exercicio_02_Heranca
{
    public class Exercicio_02_Heranca
    {
        public List<Product> produtos = new List<Product>();
        public void Exercicio()
        {
            Console.Clear();

            Console.Write("Número de produtos: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine("\nDados do produto 0{0}", i);
                Console.Write("Produto: novo, usado ou importado (n,u,i)? ");
                char decisao = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double valor = double.Parse(Console.ReadLine());

                if (decisao == 'i' || decisao == 'I')
                {
                    Console.Write("Taxa de alfândega: ");
                    double taxa = double.Parse(Console.ReadLine());
                    produtos.Add(new ImportedProduct(nome, valor, taxa));
                }
                else if (decisao == 'u' || decisao == 'U')
                {
                    Console.Write("Data de Fabricação: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    produtos.Add(new UsedProduct(nome, valor, date));
                }
                else
                {
                    produtos.Add(new Product(nome, valor));
                }
            }

            Console.WriteLine("`\n## ETIQUETA DE PREÇOS ##\n");
            foreach (var prod in produtos)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}

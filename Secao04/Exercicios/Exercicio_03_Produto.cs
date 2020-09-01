using System;
using System.Globalization;

namespace Secao04.Exercicios
{
    public class Exercicio_03_Produto
    {
        public string Nome3;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome3
            + ", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", " + Quantidade
            + " unidade(s) , Total: R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void Exercicio()
        {
            Console.Clear();

            var p = new Exercicio_03_Produto();
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome3 = Console.ReadLine();
            Console.Write("Preço: R$ ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados do produto: " + p);

            Console.Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.Write("\nDados do produto atualizado com produtos adicionados: " + p);

            Console.WriteLine("\nDigite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine("\nDados do produto atualizado com produtos removidos: " + p);
        }
    }
}

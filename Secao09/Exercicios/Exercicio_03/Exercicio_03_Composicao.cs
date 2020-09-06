using Secao09.Exercicios.Exercicio_04.Entities;
using Secao09.Exercicios.Exercicio_04.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Secao09.Exercicios
{
    public class Exercicio_03_Composicao
    {
        public void Exercicio()
        {
            Console.Clear();

            Console.WriteLine("#### LOJA DE VENDAS ####");
            Console.WriteLine("\nDigite os dados do cliente: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de Nascimento (DD/MM/YYYY): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite os dados do pedido: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client cliente = new Client(nome, email, dataNascimento);
            Order pedido = new Order(DateTime.Now, status, cliente);

            Console.Write("Digite o número de itens para adicionar ao pedido: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine($"\nDigite os dados do produto 0{i}:");
                Console.Write("Nome do produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product produto = new Product(nomeProduto, preco);

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantidade, preco, produto);
                pedido.AddItem(orderItem);
            }

            Console.WriteLine("__________________________________________________________________________________________");
            Console.WriteLine("\nResumo do pedido:");
            Console.WriteLine(pedido);
        }
    }
}

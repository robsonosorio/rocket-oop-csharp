using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Secao05.Exercicios
{
    public class Exercicio_ContaBancaria
    {
        public int Conta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Exercicio_ContaBancaria()
        {
        }

        public Exercicio_ContaBancaria(int conta, string nome, double deposito)
        {
            Conta = conta;
            Nome = nome;
            AdicionarValor(deposito);
        }
        public Exercicio_ContaBancaria(int conta, string nome)
        {
            Conta = conta;
            Nome = nome;
            Saldo = 0.0;
        }

        public void AdicionarValor(double deposito)
        {
            Saldo += deposito;
        }

        public void RetirarValor(double saque)
        {
            Saldo -= saque + (5.0);
        }

        public override string ToString()
        {
            return "Conta: " + Conta
                + " | Titular: " + Nome
                + " | Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void Exercicio()
        {
            Console.Clear();

            Exercicio_ContaBancaria cc;
            Console.WriteLine("Bem vindo ao Banco Fantasma !\n");
            Console.Write("Número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Iniciar com depósito(s/n)? ");
            char decisao = char.Parse(Console.ReadLine());

            if (decisao == 's' || decisao == 'S')
            {
                Console.Write("Digite valor inicial: R$ ");
                double saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cc = new Exercicio_ContaBancaria(conta, nome, saldoInicial);
            }
            else
            {
                cc = new Exercicio_ContaBancaria(conta, nome);
            }
            Console.WriteLine("\nDados da conta: " + cc);

            Console.Write("\nDigite valor do depósito: R$ ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cc.AdicionarValor(deposito);
            Console.WriteLine("\nDados da conta atualizado: " + cc);

            Console.Write("\nDigite valor do saque: R$ ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cc.RetirarValor(saque);
            Console.WriteLine("\nTaxa de saque: R$ 5,00");
            Console.WriteLine("\nDados da conta atualizado: " + cc);
        }
    }
}

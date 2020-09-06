﻿using System.Globalization;

namespace Secao09.Exercicios.Exercicio_04.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Product.Name + " | R$ " + Price 
                + " | Quantidade: " + Quantity 
                + " | SubTotal: R$ " + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
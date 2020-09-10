using System.Globalization;

namespace Secao10.Exercicios.Exercicio_02_Heranca.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }
        
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return Name + " | R$ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " | Taxas de Alfândega: R$ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

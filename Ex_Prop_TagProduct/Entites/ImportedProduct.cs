using System;
using System.Globalization;

namespace Ex_Prop_TagProduct.Entites
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee)
            :base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public sealed override string PriceTag()
        {
            return $"Product...: {Name} ${TotalPrice().ToString("F2",CultureInfo.InvariantCulture)} " +
                   $"(Customs Fee..: ${CustomsFee.ToString("F2",CultureInfo.InvariantCulture)})";
        }
    }
}

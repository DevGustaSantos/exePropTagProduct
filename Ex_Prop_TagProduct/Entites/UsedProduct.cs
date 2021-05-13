using System;
using System.Globalization;

namespace Ex_Prop_TagProduct.Entites
{
    class UsedProduct :Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            :base (name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public sealed override string PriceTag()
        {
            return $"Product (used)...: {Name} ${Price.ToString("F2", CultureInfo.InvariantCulture)} (Monofacture date...: {ManufactureDate})";
        }
    }
}

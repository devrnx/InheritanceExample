using System;

namespace Cap_10._01.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return $"Produto usado \nNome: {Name} \nPreco: {Price} \nData de fabricação: {ManufactureDate}";
        }
    }
}

namespace Cap_10._01.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }

        public override string priceTag()
        {
            return $"Produto importado \nNome do produto: {Name} \nPreco: {Price} \nTaxa da alfandega: {CustomFee}";
        }

        public double totalPrice()
        {
            return Price + CustomFee;
        }
    }
}

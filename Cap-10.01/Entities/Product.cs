namespace Cap_10._01.Entities
{
    class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string priceTag()
        {
            return $"Produto Comum \nNome do produto: {Name} \nPreco: {Price}";
        }
    }
}

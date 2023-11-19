namespace Final
{
    public abstract partial class Product
    {
        public string name { get; private set; }

        public Product(string name)
        {
            this.name = name;
        }
    }
}

namespace Final
{
    // ConcreteObserver
    public partial class Customer : IObserver
    {
        private string _name;
        public string _productType { get; private set; }
        public string _productCategory { get; private set; }

        public Customer(string name, string productType, string productCategory)
        {
            _name = name;
            _productType = productType;
            _productCategory = productCategory;
        }

        public void Update(Publisher publisher)
        {
            Console.WriteLine($"{_name}: received notification ");
        }
    }
}

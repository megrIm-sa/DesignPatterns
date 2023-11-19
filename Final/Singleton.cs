namespace Final
{
    // Customer database
    public partial class Singleton
    {
        private static Singleton? _instance;
        private List<Customer> _customerList;

        private Singleton()
        {
            _customerList = new List<Customer>()
            {
                new Customer("Biba", "Processor", "LowBudget"),
                new Customer("Babaluba", "Videocard", "HighPerformance")
            };
        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
                _instance = new Singleton();
            return _instance;
        }

        public Customer GetCustomer(int id) 
        {
            if (_customerList[id] != null)
                return _customerList[id];
            else throw new Exception("Invalid customer id!");
        }

        public Customer AddToList(Customer customer)
        {
            _customerList.Add(customer);
            return customer;
        }

        public void RemoveFromList(Customer customer)
        {
            if (_customerList.Contains(customer))
                _customerList.Remove(customer);
            else throw new Exception("Invalid customer!");
        }
    }
}

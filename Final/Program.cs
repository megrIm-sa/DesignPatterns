namespace Final
{
    public partial class Program
    {
        static Singleton customerDatabase = Singleton.GetInstance();
        static ConcretePublisher publisher = new ConcretePublisher();

        static void Main(string[] args)
        {
            DoCustom(customerDatabase.GetCustomer(0));

            publisher = new EmailDecorator(publisher);
            DoCustom(customerDatabase.GetCustomer(0));

            AddOwnCustom();
        }

        static private void DoCustom(Customer customer)
        {
            publisher.Attach(customer);

            if (customer._productType == "Processor")
            {
                Manufactory manufactory = new Manufactory(new ProcessorStrategy());
                manufactory.Manufacture(customer._productCategory);
            }
            else if (customer._productType == "Videocard")
            {
                Manufactory manufactory = new Manufactory(new VideoCardStrategy());
                manufactory.Manufacture(customer._productCategory);
            }

            publisher.Notify();
            publisher.Detach(customer);
            customerDatabase.RemoveFromList(customer);

            Console.WriteLine("\n--- Custom done ---\n\n");
            Console.ReadKey();
        }

        static private void AddOwnCustom()
        {
            string? input = "";

            Console.WriteLine("Enter customer's name: ");
            string? customerName = Console.ReadLine();
            if (customerName == "")
                customerName = "Anonymous";

            Console.WriteLine("Enter product type (0 - for processor (default), 1 - for videocard): ");
            string productType;
            input = Console.ReadLine();
            if (input == "1")
                productType = "Videocard";
            else productType = "Processor";

            Console.WriteLine("Enter product category (0 - low budget (default), 1 - for high performance): ");
            string productCategory;
            input = Console.ReadLine();
            if (input == "1")
                productCategory = "HighPerformance";
            else productCategory = "LowBudget";

            Console.WriteLine("Enter notifications (0 - for email, 1 - for WhatsUp. ). Write without spaces: ");
            publisher = new ConcretePublisher();
            input = Console.ReadLine();
            if (input == "0")
                publisher = new EmailDecorator(publisher);
            else if (input == "1")
                publisher = new WhatsUpDecorator(publisher);
            else if (input == "01")
            {
                publisher = new EmailDecorator(publisher);
                publisher = new WhatsUpDecorator(publisher);
            }

            Customer customer = customerDatabase.AddToList(new Customer(customerName, productType, productCategory));
            DoCustom(customer);
        }
    }
}
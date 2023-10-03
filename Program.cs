public class Order
{
    private IPaymentStrategy _paymentStrategy;

    public Order(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void Purchase(int amount)
    {
        _paymentStrategy.Pay(amount);
    }
}

public class Product
{
    public string _name { get; private set; }
    public int _cost { get; private set; }

    public Product(string name, int cost) {
        _name = name;
        _cost = cost;
    }
}

public class ProductsSingleton {
    private static ProductsSingleton _instance;

    private ProductsSingleton() {}

    public static ProductsSingleton GetInstance()
    {
        if (_instance == null)
            _instance = new ProductsSingleton();
        return _instance;
    }
    public Product GetProduct(int id)
    {
        List<Product> productList = new List<Product>() { 
            new Product("Phone", 2000), 
            new Product("Laptop", 10000) 
        };

        if (productList[id] != null)
            return productList[id];
        else throw new Exception("Invalid product id!");
    }
}


public interface IPaymentStrategy
{
    void Pay(int amount);
}

public class CreditCardPayment : IPaymentStrategy
{
    private string _cardNumber;

    public CreditCardPayment(string cardNumber)
    {
        _cardNumber = cardNumber;
    }

    public void Pay(int amount)
    {
        Console.WriteLine("Paying " + amount + "$ with " + _cardNumber + " credit card.");
    }
}

public class PayPalPayment : IPaymentStrategy
{
    private string _email;

    public PayPalPayment(string email)
    {
        _email = email;
    }

    public void Pay(int amount)
    {
        Console.WriteLine("Paying " + amount + "$ with " + _email + " PayPal.");
    }
}


class Program
{
    static void Main(string[] args)
    {
        ProductsSingleton productsSingleton = ProductsSingleton.GetInstance();
        Order order = new Order(new CreditCardPayment("7777-7777-7777-7777"));

        order.Purchase(productsSingleton.GetProduct(0)._cost);

        order.SetPaymentStrategy(new PayPalPayment("user@gmail.com"));
        order.Purchase(productsSingleton.GetProduct(1)._cost);
    }
}
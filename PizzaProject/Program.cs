namespace PizzaApp
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new MargherittaPizza();
            Console.WriteLine("Cost: " + pizza.GetCost());
            Console.WriteLine("Description: " + pizza.GetDescription());

            pizza = new PaneerDecorator(pizza);
            Console.WriteLine("Cost: " + pizza.GetCost());
            Console.WriteLine("Description: " + pizza.GetDescription());

            pizza = new JalapenoDecorator(pizza);
            Console.WriteLine("Cost: " + pizza.GetCost());
            Console.WriteLine("Description: " + pizza.GetDescription());
        }
    }
}
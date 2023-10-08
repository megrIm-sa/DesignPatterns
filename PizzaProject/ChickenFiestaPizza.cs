namespace PizzaApp
{
    public partial class ChickenFiestaPizza : IPizza
    {
        public int GetCost()
        {
            return 24;
        }

        public string GetDescription()
        {
            return "Default ChickenFiesta pizza";
        }
    }
}
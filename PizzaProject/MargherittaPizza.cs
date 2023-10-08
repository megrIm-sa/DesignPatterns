namespace PizzaApp
{
    public partial class MargherittaPizza : IPizza
    {
        public int GetCost()
        {
            return 18;
        }

        public string GetDescription()
        {
            return "Default Margheritta pizza";
        }
    }
}
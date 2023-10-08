namespace PizzaApp
{
    public partial class PeppyPaneerPizza : IPizza
    {
        public int GetCost()
        {
            return 20;
        }

        public string GetDescription()
        {
            return "Default PeppyPaneer pizza";
        }
    }
}
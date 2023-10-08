namespace PizzaApp
{
    public partial class FarmHousePizza : IPizza
    {
        public int GetCost()
        {
            return 23;
        }

        public string GetDescription()
        {
            return "Default FarmHouse pizza";
        }
    }
}
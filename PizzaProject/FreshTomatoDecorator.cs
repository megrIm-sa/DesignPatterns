namespace PizzaApp
{
    public partial class FreshTomatoDecorator : PizzaDecorator
    {
        public FreshTomatoDecorator(IPizza pizza) : base(pizza) { }

        public override int GetCost()
        {
            return base.GetCost() + 1;

        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", with tomato";
        }
    }
}
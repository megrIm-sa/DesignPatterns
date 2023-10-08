namespace PizzaApp
{
    public partial class BarbequeDecorator : PizzaDecorator
    {
        public BarbequeDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override int GetCost()
        {
            return base.GetCost() + 1;

        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", with barbeque";
        }
    }
}
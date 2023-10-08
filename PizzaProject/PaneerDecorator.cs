namespace PizzaApp
{
    public partial class PaneerDecorator : PizzaDecorator
    {
        public PaneerDecorator(IPizza pizza) : base(pizza) { }

        public override int GetCost()
        {
            return base.GetCost() + 2;

        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", with paneer";
        }
    }
}
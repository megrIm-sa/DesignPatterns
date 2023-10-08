namespace PizzaApp
{
    public partial class JalapenoDecorator : PizzaDecorator
    {
        public JalapenoDecorator(IPizza pizza) : base(pizza) { }

        public override int GetCost()
        {
            return base.GetCost() + 1;

        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", with jalapeno";
        }
    }
}
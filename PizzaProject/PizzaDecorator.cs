namespace PizzaApp
{
    public abstract partial class PizzaDecorator : IPizza
    {
        protected IPizza pizza;

        public PizzaDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public virtual string GetDescription()
        {
            return pizza.GetDescription();
        }
        public virtual int GetCost()
        {
            return pizza.GetCost();
        }
    }
}
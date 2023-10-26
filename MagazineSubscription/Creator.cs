namespace MagazineSubscription
{
    public abstract partial class Creator
    {
        public abstract IProduct FactoryMethod();

        public string GetProductType()
        {
            return FactoryMethod().GetProductType();
        }
    }
}

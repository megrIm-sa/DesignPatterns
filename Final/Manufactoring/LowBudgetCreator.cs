namespace Final
{
    public partial class LowBudgetCreator : Creator
    {
        public override Product CreateProduct(string name)
        {
            return new LowBudgetProduct(name);
        }
    }
}

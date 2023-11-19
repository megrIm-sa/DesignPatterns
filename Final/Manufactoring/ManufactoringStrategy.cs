namespace Final
{
    public abstract partial class ManufactoringStrategy
    {
        protected LowBudgetCreator _lowBudgetCreator = new LowBudgetCreator();
        protected HighPerformanceCreator _highPerformanceCreator = new HighPerformanceCreator();

        public abstract void Manufacture(string catefory);
    }
}

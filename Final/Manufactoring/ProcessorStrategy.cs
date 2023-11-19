namespace Final
{
    public partial class ProcessorStrategy : ManufactoringStrategy
    {
        public override void Manufacture(string category)
        {
            if (category == "LowBudget")
                Console.WriteLine("Product is done: " + _lowBudgetCreator.CreateProduct("AMD Ryzen 3").name);
            else if (category == "HighPerformance")
                Console.WriteLine("Product is done: " + _highPerformanceCreator.CreateProduct("AMD Ryzen 9").name);
        }
    }
}

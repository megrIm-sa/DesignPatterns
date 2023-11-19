namespace Final
{
    public partial class VideoCardStrategy : ManufactoringStrategy
    {
        public override void Manufacture(string category)
        {
            if (category == "LowBudget")
                Console.WriteLine("Product is done: " + _lowBudgetCreator.CreateProduct("AMD Radeon RX 560").name);
            else if (category == "HighPerformance")
                Console.WriteLine("Product is done: " + _highPerformanceCreator.CreateProduct("AMD RX 7900").name);
        }
    }
}

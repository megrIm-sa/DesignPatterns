namespace Final
{
    public partial class HighPerformanceCreator : Creator
    {
        public override Product CreateProduct(string name)
        {
            return new HighPerformanceProduct(name);
        }
    }
}

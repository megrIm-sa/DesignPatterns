namespace Final
{
    public partial class Manufactory
    {
        private ManufactoringStrategy _manufactureStrategy;

        public Manufactory(ManufactoringStrategy manufactureStrategy)
        {
            _manufactureStrategy = manufactureStrategy;
        }

        public void SetManufactureStrategy(ManufactoringStrategy manufactureStrategy)
        {
            _manufactureStrategy = manufactureStrategy;
        }

        public void Manufacture(string productCategory)
        {
            _manufactureStrategy.Manufacture(productCategory);
        }
    }
}

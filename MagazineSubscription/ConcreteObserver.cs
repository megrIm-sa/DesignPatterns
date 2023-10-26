namespace MagazineSubscription
{
    public partial class ConcreteObserver : IObserver
    {
        public string name { get; private set; }
        public ConcreteObserver(string name)
        {
            this.name = name;
        }

        public void Update(Publisher publisher, Creator creator)
        {
            Console.WriteLine($"{this.name}: received {creator.GetProductType()} by {publisher.name}.");
        }
    }
}

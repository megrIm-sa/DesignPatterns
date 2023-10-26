namespace MagazineSubscription
{
    // ConcretePublisher
    public partial class ConcretePublisher : Publisher
    {
        private Creator _creator;
        private List<IObserver> _observers = new List<IObserver>();

        public ConcretePublisher(string name) : base(name) { }

        public override void Attach(IObserver observer)
        {
            Console.WriteLine("ConcretePublisher: Attached an observer.");
            _observers.Add(observer);
        }

        public override void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("ConcretePublisher: Detached an observer.");
        }

        public override void Notify()
        {
            Console.WriteLine("ConcretePublisher: Notifying observers...");

            foreach (var observer in _observers)
                observer.Update(this, _creator);
        }

        public void ChangeCreator(Creator creator)
        {
            _creator = creator;
        }

        public void ReleaseMagazine()
        {
            Console.WriteLine("New magazine released!");
            Notify();
        }
    }
}

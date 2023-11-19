namespace Final
{
    // ConcretePublisher, ConcreteComponent (from decorator)
    public partial class ConcretePublisher : Publisher
    {
        private List<IObserver> _observers = new List<IObserver>();

        public override void Attach(IObserver observer)
        {
            Console.WriteLine(ToString() + ": Attached an observer");
            _observers.Add(observer);
        }

        public override void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine(ToString() + ": Detached an observer");
        }

        public override void Notify()
        {
            Console.WriteLine(ToString() + ": Notifying observers " + NotificationService());

            foreach (var observer in _observers)
                observer.Update(this);
        }

        public override string NotificationService()
        {
            return "via App";
        }
    }
}
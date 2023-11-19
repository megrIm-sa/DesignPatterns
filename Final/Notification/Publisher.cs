namespace Final
{
    // Publisher, Component (from decorator)
    public abstract partial class Publisher
    {
        public abstract void Attach(IObserver observer);

        public abstract void Detach(IObserver observer);

        public abstract void Notify();

        public abstract string NotificationService();
    }
}

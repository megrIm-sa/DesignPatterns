namespace MagazineSubscription
{
    // Publisher
    public abstract partial class Publisher
    {
        public string name { get; private set; }
        public Publisher(string name)
        {
            this.name = name;
        }

        public virtual void Attach(IObserver observer) { }

        public virtual void Detach(IObserver observer) { }

        public virtual void Notify() { }
    }
}

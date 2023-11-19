namespace Final
{
    public partial class Decorator : ConcretePublisher
    {
        protected ConcretePublisher publisher;

        public Decorator(ConcretePublisher publisher)
        {
            this.publisher = publisher;
        }

        public override string NotificationService()
        {
            return publisher.NotificationService();
        }
    }
}

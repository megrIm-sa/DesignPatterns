namespace Final
{
    public partial class WhatsUpDecorator : Decorator
    {
        public WhatsUpDecorator(ConcretePublisher publisher) : base(publisher) { }

        public override string NotificationService()
        {
            return base.NotificationService() + ", WhatsUp";
        }
    }
}

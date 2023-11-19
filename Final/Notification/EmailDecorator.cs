namespace Final
{
    public partial class EmailDecorator : Decorator
    {
        public EmailDecorator(ConcretePublisher publisher) :  base(publisher) { }
        private Notificator _notificator = new Adapter(new MailingService());

        public override string NotificationService()
        {
            _notificator.SendNotification();
            return base.NotificationService() + ", Email";
        }
    }
}

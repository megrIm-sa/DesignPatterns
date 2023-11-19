namespace Final
{
    public partial class Adapter : Notificator
    { 
        private MailingService _mailingService;

        public Adapter (MailingService mailingService)
        {
            _mailingService = mailingService;
        }

        public override void SendNotification()
        {
            _mailingService.SendEmail();
        }
    }
}

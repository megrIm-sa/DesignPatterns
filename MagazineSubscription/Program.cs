namespace MagazineSubscription
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            var publisher = new ConcretePublisher("NewYorkTimes");
            var observer = new ConcreteObserver("Some Person");
            publisher.ChangeCreator(new ConcreteCreator1());

            publisher.Attach(observer);
            publisher.ReleaseMagazine();
            publisher.Detach(observer);
            publisher.ReleaseMagazine();
        }
    }
}
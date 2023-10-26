namespace MagazineSubscription
{
    public partial interface IObserver
    {
        void Update(Publisher publisher, Creator creator);
    }
}

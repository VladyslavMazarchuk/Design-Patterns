using FactoryMethod;

class Program
{
    static void Main(string[] args)
    {
        SubscriptionCreator websiteCreator = new WebSite();
        Subscription websiteSubscription = websiteCreator.CreateDomesticSubscription();
        websiteSubscription.ShowDetails();

        SubscriptionCreator mobileAppCreator = new MobileApp();
        Subscription mobileAppSubscription = mobileAppCreator.CreateEducationalSubscription();
        mobileAppSubscription.ShowDetails();

        SubscriptionCreator managerCallCreator = new ManagerCall();
        Subscription managerCallSubscription = managerCallCreator.CreatePremiumSubscription();
        managerCallSubscription.ShowDetails();
    }
}

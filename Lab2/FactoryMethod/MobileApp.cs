using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class MobileApp : SubscriptionCreator
    {
        public override Subscription CreateDomesticSubscription()
        {
            return new DomesticSubscription();
        }

        public override Subscription CreateEducationalSubscription()
        {
            return new EducationalSubscription();
        }

        public override Subscription CreatePremiumSubscription()
        {
            return new PremiumSubscription();
        }

        public override string GetCreatorType()
        {
            return "Mobile App";
        }
    }
}
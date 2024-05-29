using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PremiumSubscription : Subscription
    {
        public override decimal MonthlyFee => 20.00m;
        public override int MinimumPeriod => 3;
        public override List<string> Channels => new List<string> { "Всі канали" };
        public override List<string> Features => new List<string> { "4K якість", "Пріоритетна підтримка" };

        public override void ShowDetails()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Преміум підписка: 20$/місяць, мінімум 3 місяці.");
            Console.WriteLine("Канали: " + string.Join(", ", Channels));
            Console.WriteLine("Можливості: " + string.Join(", ", Features));
        }
    }
}
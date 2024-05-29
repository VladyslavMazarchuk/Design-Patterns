using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class EducationalSubscription : Subscription
    {
        public override decimal MonthlyFee => 5.00m;
        public override int MinimumPeriod => 12;
        public override List<string> Channels => new List<string> { "Освітній канал 1", "Освітній канал 2" };
        public override List<string> Features => new List<string> { "HD якість", "Без реклами" };

        public override void ShowDetails()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Освітня підписка: 5$/місяць, мінімум 12 місяців.");
            Console.WriteLine("Канали: " + string.Join(", ", Channels));
            Console.WriteLine("Можливості: " + string.Join(", ", Features));
        }
    }
}

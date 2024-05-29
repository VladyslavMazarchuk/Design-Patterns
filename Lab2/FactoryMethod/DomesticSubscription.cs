using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class DomesticSubscription : Subscription
    {
        public override decimal MonthlyFee => 10.00m;
        public override int MinimumPeriod => 6;
        public override List<string> Channels => new List<string> { "Місцеві новини", "Розваги" };
        public override List<string> Features => new List<string> { "HD якість", "Базова підтримка" };

        public override void ShowDetails()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Домашня підписка: 10$/місяць, мінімум 6 місяців.");
            Console.WriteLine("Канали: " + string.Join(", ", Channels));
            Console.WriteLine("Можливості: " + string.Join(", ", Features));
        }
    }

}

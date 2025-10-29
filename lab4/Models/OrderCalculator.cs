using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersLibrary.Models
{
    public class OrderCalculator
    {
        // Метод працює з колекцією ICalculable приймає список посилань на об'єкти, які гарантовано мають поведінку, визначену в ICalculable
        public static double GetTotalSum(List<ICalculable> calculables)
        {
            double sum = 0;
            foreach (var item in calculables)
            {
                sum += item.GetFinalAmount();
            }
            return sum;
        }
        public static List<string> GetClientIdentifiers(List<IClientInfo> clientItems)
        {
            var identifiers = new List<string>();
            foreach (var item in clientItems)
            {
                identifiers.Add(item.ClientIdentifier);
            }
            return identifiers;
        }
    
}
}

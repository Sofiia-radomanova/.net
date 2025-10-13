using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersLibrary.Models
{
        public class OrderCalculator
        {
            public static double GetTotalSum(List<Order> orders)
            {
                double sum = 0;
                foreach (var o in orders)
                {
                    sum += o.GetFinalAmount();
                }
                return sum;
            }
        }
}

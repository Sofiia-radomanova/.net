using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersLibrary.Models
{
    public class OnlineOrder : Order
    {
        public double DeliveryCost { get; set; }

        public OnlineOrder(int number, double total, double delivery)
        {
            Number = number;
            TotalAmount = total;
            DeliveryCost = delivery;
        }

        public override double GetFinalAmount()
        {
            return TotalAmount + DeliveryCost;
        }

    }
}

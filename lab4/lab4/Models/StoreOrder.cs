using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersLibrary.Models
{
    public class StoreOrder : Order
    {
        public string ClientName { get; set; }

        public StoreOrder(int number, string name, double total)
        {
            Number = number;
            ClientName = name;
            TotalAmount = total;
        }

        public override double GetFinalAmount()
        {
            return TotalAmount; 
        }
    }
}

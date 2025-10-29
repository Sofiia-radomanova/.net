using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersLibrary.Models
{
    // Новий клас, що реалізує ICalculable
    public class GiftCard : ICalculable
    {
        public int Id { get; set; }
        public double Value { get; set; }
        

        public GiftCard(int id, double value)
        {
            Id = id;
            Value = value;
        }

        // Реалізація ICalculable. Повертає номінал картки.
        public double GetFinalAmount()
        {
            return Value;
        }

    }
}
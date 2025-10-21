using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrdersLibrary.Models
{
    public abstract class Order : IOrderProperties, ICalculable
    {
        public int Number { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public double TotalAmount { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public virtual void AddGoods(OrderItem item)
        {
            Items.Add(item);
            TotalAmount += item.GetTotal(); // оновлюємо TotalAmount
        }
        // Віртуальний метод 
        public abstract double GetFinalAmount();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersLibrary.Models
{
    // Інтерфейс для загальних властивостей замовлення
    public interface IOrderProperties
    {
        int Number { get; set; }
        System.DateTime Date { get; set; }
        double TotalAmount { get; set; }
    }
}

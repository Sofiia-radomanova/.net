using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersLibrary.Models
{
    // Інтерфейс для об'єктів, які можуть обчислювати кінцеву суму
    public interface ICalculable
    {
        double GetFinalAmount();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersLibrary.Models
{
    // Інтерфейс для інформації про клієнта/покупця
    public interface IClientInfo
    {
        string ClientIdentifier { get; }
    }
}

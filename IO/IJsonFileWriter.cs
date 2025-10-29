using System.Collections.Generic;
using System.Threading.Tasks;


namespace lab6_new.Interfaces
{
    public interface IJsonFileWriter<T>
    {
        Task WriteAsync(string path, IEnumerable<T> items);
    }
}
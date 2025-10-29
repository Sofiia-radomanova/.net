using System.Collections.Generic;
using System.Threading.Tasks;


namespace lab6_new.Interfaces
{
    public interface IJsonFileReader<T>
    {
        Task<List<T>> ReadAsync(string path);
    }
}
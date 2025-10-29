using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using lab6_new.Interfaces;


namespace lab6_new.IO
{
    public class JsonFileWriter<T> : IJsonFileWriter<T>
    {
        public async Task WriteAsync(string path, IEnumerable<T> items)
        {
            // Створюємо або відкриваємо файл для запису
            using var file = File.Create(path);

            // Серіалізуємо колекцію у JSON і записуємо у файл
            await JsonSerializer.SerializeAsync(file, items);

            // Переконуємося, що всі дані записані на диск
            await file.FlushAsync();
        }

    }
}
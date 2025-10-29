using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using lab6_new.Interfaces;


namespace lab6_new.IO
{
    public class JsonFileReader<T> : IJsonFileReader<T>
    {
        public async Task<List<T>> ReadAsync(string path)
        {
            // Якщо файлу немає, повертаємо порожній список
            if (!File.Exists(path))
                return new List<T>();

            // Відкриваємо файл для читання
            using var file = File.OpenRead(path);

            // Зчитуємо JSON з файлу і перетворюємо у список об’єктів
            var data = await JsonSerializer.DeserializeAsync<List<T>>(file);

            // Якщо файл був порожній, повертаємо порожній список
            return data ?? new List<T>();
        }

    }
}
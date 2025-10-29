using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab6_new.Interfaces;
using lab6_new.Models;

namespace lab6_new.Catalogs
{
    public class StudentCatalog
    {
        private readonly List<Student> _students = new();
        public IReadOnlyList<Student> Students => _students.AsReadOnly();

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            _students.Remove(student);
        }

        public void Clear()
        {
            _students.Clear();
        }

        // Фільтрація студентів, які успішно склали сесію
        public List<Student> GetSuccessfulStudents()
        {
            return _students.Where(s => s.PassedSessionSuccessfully()).ToList();
        }

        // Сортування за номером групи
        public List<Student> SortByGroupNumber()
        {
            return _students.OrderBy(s => s.GroupNumber).ThenBy(s => s.FullName).ToList();
        }

        // Сортування успішних студентів за номером групи
        public List<Student> GetSortedSuccessfulStudents()
        {
            return GetSuccessfulStudents()
                .OrderBy(s => s.GroupNumber)
                .ThenBy(s => s.FullName)
                .ToList();
        }

        // Методи для роботи з файлами
        public async Task SaveAsync(string filePath, IJsonFileWriter<Student> writer)
        {
            await writer.WriteAsync(filePath, _students);
        }

        public async Task LoadAsync(string filePath, IJsonFileReader<Student> reader)
        {
            var students = await reader.ReadAsync(filePath);
            _students.Clear();
            _students.AddRange(students);
        }
    }
}
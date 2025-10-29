using System;
using System.Collections.Generic;
using System.Linq;

namespace lab6_new.Models
{
    public class Student : IComparable<Student>
    {
        public string FullName { get; set; }
        public string GroupNumber { get; set; }
        public List<ExamResult> ExamResults { get; set; } = new List<ExamResult>();

        public Student() { }

        public Student(string fullName, string groupNumber)
        {
            FullName = fullName;
            GroupNumber = groupNumber;
        }

        // Додавання результату іспиту
        public void AddExamResult(string subject, int score)
        {
            ExamResults.Add(new ExamResult(subject, score));
        }

        // Перевірка чи успішно склав сесію (всі оцінки >= 60)
        public bool PassedSessionSuccessfully()
        {
            return ExamResults.Count >= 3 && ExamResults.All(e => e.Score >= 60);
        }

        // Середній бал
        public double GetAverageScore()
        {
            return ExamResults.Any() ? ExamResults.Average(e => e.Score) : 0; //тернарний оператор якщо ... ? результат : інакше 0
        }

        public int CompareTo(Student? other)
        {
            if (other == null) return 1;

            // Спочатку сортуємо за номером групи, потім за ПІБ
            int groupComparison = string.Compare(GroupNumber, other.GroupNumber, StringComparison.Ordinal);
            return groupComparison != 0
                ? groupComparison
                : string.Compare(FullName, other.FullName, StringComparison.CurrentCultureIgnoreCase);
        }

        public override string ToString()
        {
            var exams = string.Join(", ", ExamResults.Select(e => $"{e.Subject}: {e.Score}"));
            return $"{FullName} | Група: {GroupNumber} | {exams} | Середній: {GetAverageScore():F1}";
        }
    }

    // Допоміжний клас для результатів іспитів
    public class ExamResult
    {
        public string Subject { get; set; }
        public int Score { get; set; }

        public ExamResult(string subject, int score)
        {
            Subject = subject;
            Score = score;
        }
    }
}
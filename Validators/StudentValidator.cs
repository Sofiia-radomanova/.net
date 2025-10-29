using System;
using System.Linq;
using lab6_new.Models;

namespace lab6_new.Validators
{
    public static class StudentValidator
    {
        public static string Validate(Student student)
        {
            if (student == null) return "Студент не може бути null.";
            if (string.IsNullOrWhiteSpace(student.FullName)) return "ПІБ є обов'язковим.";
            if (string.IsNullOrWhiteSpace(student.GroupNumber)) return "Номер групи є обов'язковим.";
            if (student.ExamResults.Count < 3) return "Потрібно мінімум 3 результати іспитів.";

            foreach (var exam in student.ExamResults)
            {
                if (exam.Score < 0 || exam.Score > 100)
                    return $"Оцінка з {exam.Subject} повинна бути від 0 до 100.";
            }

            return string.Empty;
        }

        public static string ValidateExamScore(int score)
        {
            return score >= 0 && score <= 100 ? string.Empty : "Оцінка повинна бути від 0 до 100.";
        }
    }
}
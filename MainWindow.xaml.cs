using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using lab6_new.Catalogs;
using lab6_new.Interfaces;
using lab6_new.IO;
using lab6_new.Models;
using lab6_new.Validators;

namespace lab6_new
{
    public partial class MainWindow : Window
    {
        private readonly StudentCatalog _catalog;
        private readonly IJsonFileWriter<Student> _writer;
        private readonly IJsonFileReader<Student> _reader;
        private readonly string _defaultPath;

        public MainWindow()
        {
            InitializeComponent();

            _catalog = new StudentCatalog();
            _writer = new JsonFileWriter<Student>();
            _reader = new JsonFileReader<Student>();

            _defaultPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "students_variant8.json"
            );

            RefreshStudentComboBox();
            RefreshView(_catalog.Students);
        }

        private void RefreshView(System.Collections.IEnumerable items)
        {
            DataGridStudents.ItemsSource = null;
            DataGridStudents.ItemsSource = items;
        }

        private void RefreshStudentComboBox()
        {
            CmbStudents.ItemsSource = null;
            CmbStudents.ItemsSource = _catalog.Students;
            CmbStudents.SelectedIndex = -1;
        }

        // Додавання нового студента
        private void BtnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            var fullName = TxtFullName.Text.Trim();
            var groupNumber = TxtGroupNumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(groupNumber))
            {
                MessageBox.Show("Будь ласка, заповніть ПІБ та номер групи.");
                return;
            }

            var student = new Student(fullName, groupNumber);

            _catalog.AddStudent(student);
            RefreshStudentComboBox();
            RefreshView(_catalog.Students);

            TxtFullName.Clear();
            TxtGroupNumber.Clear();
            TxtFullName.Focus();
        }

        // Додавання результату іспиту
        private void BtnAddExam_Click(object sender, RoutedEventArgs e)
        {
            if (CmbStudents.SelectedItem is not Student selectedStudent)
            {
                MessageBox.Show("Будь ласка, оберіть студента.");
                return;
            }

            var subject = TxtSubject.Text.Trim();
            if (string.IsNullOrWhiteSpace(subject))
            {
                MessageBox.Show("Будь ласка, введіть назву предмету.");
                return;
            }

            if (!int.TryParse(TxtScore.Text, out int score))
            {
                MessageBox.Show("Будь ласка, введіть коректну оцінку.");
                return;
            }

            var validationError = StudentValidator.ValidateExamScore(score);
            if (!string.IsNullOrEmpty(validationError))
            {
                MessageBox.Show(validationError);
                return;
            }

            selectedStudent.AddExamResult(subject, score);

            // Оновлюємо DataGrid
            RefreshView(DataGridStudents.ItemsSource);
            RefreshStudentComboBox();

            TxtSubject.Clear();
            TxtScore.Clear();
        }

        // Видалення студента
        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridStudents.SelectedItem is Student student)
            {
                _catalog.RemoveStudent(student);
                RefreshStudentComboBox();
                RefreshView(_catalog.Students);
            }
        }

        // Показати успішних студентів
        private void BtnShowSuccessful_Click(object sender, RoutedEventArgs e)
        {
            var successfulStudents = _catalog.GetSortedSuccessfulStudents();
            RefreshView(successfulStudents);
        }

        // Показати всіх студентів
        private void BtnShowAll_Click(object sender, RoutedEventArgs e)
        {
            RefreshView(_catalog.Students);
        }

        // Сортувати за групою
        private void BtnSortByGroup_Click(object sender, RoutedEventArgs e)
        {
            var sorted = _catalog.SortByGroupNumber();
            RefreshView(sorted);
        }

        // Збереження
        private async void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await _catalog.SaveAsync(_defaultPath, _writer);
                MessageBox.Show($"Дані збережено у файл: {_defaultPath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка збереження: {ex.Message}");
            }
        }

        // Завантаження
        private async void BtnLoad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await _catalog.LoadAsync(_defaultPath, _reader);
                RefreshStudentComboBox();
                RefreshView(_catalog.Students);
                MessageBox.Show("Дані завантажено успішно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження: {ex.Message}");
            }
        }
    }
}
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace OmaSovellus
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> homeworkTasks;

        public MainWindow()
        {
            InitializeComponent();
            homeworkTasks = new ObservableCollection<string>();
            homeworkListBox.ItemsSource = homeworkTasks;
        }

        private void AddHomework_Click(object sender, RoutedEventArgs e)
        {
            // Lisää uusi kotitehtävä listalle
            string newHomework = homeworkTextBox.Text;
            if (!string.IsNullOrWhiteSpace(newHomework))
            {
                homeworkTasks.Add(newHomework);
                homeworkTextBox.Clear();
            }
        }

        private void GenerateHomework_Click(object sender, RoutedEventArgs e)
        {
            // Generoi satunnainen kotitehtävä
            if (homeworkTasks.Count > 0)
            {
                Random random = new Random();
                int randomIndex = random.Next(homeworkTasks.Count);
                MessageBox.Show("Generated Homework: " + homeworkTasks[randomIndex], "Homework Generator");
            }
            else
            {
                MessageBox.Show("No homework tasks available.", "Homework Generator");
            }
        }
    }
}
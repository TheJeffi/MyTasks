using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MyTasks.Pages
{
    /// <summary>
    /// Логика взаимодействия для CreateTaskWindow.xaml
    /// </summary>
    public partial class CreateTaskWindow : Window
    {
        public CreateTaskWindow()
        {
            InitializeComponent();

            CreateTaskButton.Click += Create_Task;

            GetTaskData();
        }

        private void Create_Task(object sender, RoutedEventArgs e)
        {
            GetTaskData();
        }

        private void GetTaskData()
        {
            var taskName = TaskName.Text.Trim();
            var taskStartDate = TaskCreateDate.Text.Trim();
            var taskEndDate = TaskEndDate.Text.Trim();
            var taskPuprose = TaskPurpose.Text.Trim();

            MessageBox.Show($"{taskName}, {taskStartDate}, {taskEndDate}, {taskPuprose}");
        }
    }
}

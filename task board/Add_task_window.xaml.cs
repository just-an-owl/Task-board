using System;
using System.Windows;

namespace task_board
{
    /// <summary>
    /// Логика взаимодействия для Add_task_window.xaml
    /// </summary>
    public partial class Add_task_window : Window
    {
        public delegate void Message(Task task);
        public event Message Add_task;
        Task.Type_task Type_Task = Task.Type_task.urgent;        
        bool Status = false;
       

        private void On_Development_Stage(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("On developmenent stage");
        }
        private void Cancel_Button(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Add_Button(object sender, RoutedEventArgs e)
        {
            Task task = new Task(Topic.Text, Description.Text, Convert.ToDateTime(Date.Text), Status, Type_Task);            
            Add_task(task);
            this.Close();
        }

       

        public Add_task_window()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Type_Task = Task.Type_task.urgent;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            Type_Task = Task.Type_task.coming_days;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            Type_Task = Task.Type_task.next_month;
        }
    }
}

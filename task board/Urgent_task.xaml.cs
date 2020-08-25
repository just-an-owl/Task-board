using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Serialization;

namespace task_board
{
    /// <summary>
    /// Логика взаимодействия для Urgent_task.xaml
    /// </summary>
    public partial class Urgent_task : Window
    {
        List<Task> tasks = new List<Task>() { };
        List<Task> tasks1 = new List<Task>() { };
        List<Task> tasks2 = new List<Task>() { };
        string Urgent_Task_File_Name = @"C:\task board\UrgentTask.xml";
        string Coming_Days_Task_File_Name = @"C:\task board\ComingDaysTask.xml";
        string Next_Month_Task_File_Name = @"C:\task board\NextMonthTask.xml";

        private void Open_Task_Lists()
        {
            bool check_xml = false;
            using (StreamReader fs = new StreamReader(Urgent_Task_File_Name))
            {
                if (fs.ReadToEnd().Trim().Length > 0)
                {
                    check_xml = true;
                }
            }
            if (check_xml)
                using (FileStream fs = new FileStream(Urgent_Task_File_Name, FileMode.OpenOrCreate))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Task>));
                    tasks = (List<Task>)xmlSerializer.Deserialize(fs);
                }
            Task_list_urgent.ItemsSource = tasks;


            check_xml = false;
            using (StreamReader fs = new StreamReader(Coming_Days_Task_File_Name))
            {
                if (fs.ReadToEnd().Trim().Length > 0)
                {
                    check_xml = true;
                }
            }
            if (check_xml)
                using (FileStream fs = new FileStream(Coming_Days_Task_File_Name, FileMode.OpenOrCreate))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Task>));
                    tasks1 = (List<Task>)xmlSerializer.Deserialize(fs);
                }
            Task_list_coming_days.ItemsSource = tasks1;


            check_xml = false;
            using (StreamReader fs = new StreamReader(Next_Month_Task_File_Name))
            {
                if (fs.ReadToEnd().Trim().Length > 0)
                {
                    check_xml = true;
                }
            }
            if (check_xml)
                using (FileStream fs = new FileStream(Next_Month_Task_File_Name, FileMode.OpenOrCreate))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Task>));
                    tasks2 = (List<Task>)xmlSerializer.Deserialize(fs);
                }
            Task_list_next_month.ItemsSource = tasks2;

        }

        public Urgent_task()
        {
            InitializeComponent();
            Open_Task_Lists();
        }

        private void Exit_button_Click(object sender, RoutedEventArgs e)
        {            
            this.Close();            
        }

        private void Task_list2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Task_window task_Window = new Task_window();
            Task task = (Task)Task_list_urgent.Items[Task_list_urgent.SelectedIndex];
            //task_Window.Owner = this;
            task_Window.Title_task.Text = task.Name;
            task_Window.Text.Text = task.Text;
            task_Window.Date.Text = Convert.ToString(task.Date);
            if (task.Status_Task)
            {
                task_Window.Status_false.Visibility = Visibility.Collapsed;
            }
            if (!task.Status_Task)
            {
                task_Window.Status_true.Visibility = Visibility.Collapsed;
            }
            task_Window.iter = Task_list_urgent.SelectedIndex;
            task_Window.File_name = Urgent_Task_File_Name;
            task_Window.WindowStartupLocation = WindowStartupLocation.CenterOwner;

            task_Window.Show();
            this.Close();
           // task_Window.Closed += Task_Window_Closed;
        }

        private void Task_Window_Closed(object sender, EventArgs e)
        {
            Open_Task_Lists();
        }

        private void Task_list_coming_days_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Task_window task_Window = new Task_window();
            task_Window.File_name = Coming_Days_Task_File_Name;
            Task task = (Task)Task_list_coming_days.Items[Task_list_coming_days.SelectedIndex];
            //task_Window.Owner = this;
            task_Window.Title_task.Text = task.Name;
            task_Window.Text.Text = task.Text;
            task_Window.Date.Text = Convert.ToString(task.Date);
            if (task.Status_Task)
            {
                task_Window.Status_false.Visibility = Visibility.Collapsed;
            }
            if (!task.Status_Task)
            {
                task_Window.Status_true.Visibility = Visibility.Collapsed;
            }
            task_Window.iter = Task_list_coming_days.SelectedIndex;
            task_Window.WindowStartupLocation = WindowStartupLocation.CenterOwner;

            task_Window.Show();
            this.Close();

            // task_Window.Closed += Task_Window_Closed;

        }

        private void Task_list_next_month_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Task_window task_Window = new Task_window();
            Task task = (Task)Task_list_next_month.Items[Task_list_next_month.SelectedIndex];
            //task_Window.Owner = this;
            task_Window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            task_Window.Title_task.Text = task.Name;
            task_Window.Text.Text = task.Text;
            task_Window.Date.Text = Convert.ToString(task.Date);
            if (task.Status_Task)
            {
                task_Window.Status_false.Visibility = Visibility.Collapsed;
            }
            if (!task.Status_Task)
            {
                task_Window.Status_true.Visibility = Visibility.Collapsed;
            }
            task_Window.iter = Task_list_next_month.SelectedIndex;
            task_Window.File_name = Next_Month_Task_File_Name;
            task_Window.Show();

            // task_Window.Closed += Task_Window_Closed;
            this.Close();

        }
    }
}

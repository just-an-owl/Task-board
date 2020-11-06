using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

namespace task_board
{
    /// <summary>
    /// Логика взаимодействия для Task_page.xaml
    /// </summary>
    public partial class Task_page : Window
    {
        List<Task> tasks = new List<Task>() { };
        List<Task> tasks1 = new List<Task>() { };
        List<Task> tasks2 = new List<Task>() { };
        string Urgent_Task_File_Name = @"C:\task board\UrgentTask.xml";
        string Coming_Days_Task_File_Name = @"C:\task board\ComingDaysTask.xml";
        string Next_Month_Task_File_Name = @"C:\task board\NextMonthTask.xml";
        int NumberTaskList;
        int NumberTask;

        public Task_page()
        {
            InitializeComponent();
            Open_Task_Lists();
        }

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

        private void Edit_button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click");
            switch (NumberTaskList)
            {
                case 0:
                    tasks[NumberTask].Text = this.Content_task.Text;
                    MessageBox.Show("change");
                    MessageBox.Show(tasks[NumberTask].Text);
                    break;
            }
                
        }

        private void Task_list_urgent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //int i = this.Task_list_urgent.SelectedIndex;
            NumberTaskList = 0;
            this.Content_task.Clear();
            MessageBox.Show(System.Convert.ToString(this.Task_list_urgent.SelectedIndex));
            NumberTask = this.Task_list_urgent.SelectedIndex;
            this.Content_task.Text = tasks[this.Task_list_urgent.SelectedIndex].Text;
            //this.Task_list_urgent.SelectedIndex = -1;

        }

        private void Task_list_coming_days_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            NumberTaskList = 1;
            NumberTask = this.Task_list_coming_days.SelectedIndex;
            this.Content_task.Clear();
            this.Content_task.Text = tasks1[this.Task_list_coming_days.SelectedIndex].Text;
            //this.Task_list_urgent.SelectedIndex = -1;
        }

        private void Task_list_next_month_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NumberTaskList = 1;
            NumberTask = this.Task_list_coming_days.SelectedIndex;
            this.Content_task.Text = tasks[this.Task_list_coming_days.SelectedIndex].Text;
        }
    }
}

using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Xml.Serialization;

namespace task_board
{
    /// <summary>
    /// Логика взаимодействия для Task_window.xaml
    /// </summary>
    public partial class Task_window : Window
    {
        public string File_name;
        public int iter;
        List<Task> tasks = new List<Task>() { };
        public Task_window()
        {
            InitializeComponent();
            this.Closed += Task_window_Closed;
        }

        private void Task_window_Closed(object sender, System.EventArgs e)
        {
            Urgent_task urgent_Task = new Urgent_task();
            urgent_Task.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            urgent_Task.Show();
        }

        private void Exit_button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Conpleted_button_Click(object sender, RoutedEventArgs e)
        {
            bool check_xml = false;
            using (StreamReader fs = new StreamReader(File_name))
            {
                if (fs.ReadToEnd().Trim().Length > 0)
                {
                    check_xml = true;
                }
            }
            if (check_xml)
                using (FileStream fs = new FileStream(File_name, FileMode.OpenOrCreate))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Task>));
                    tasks = (List<Task>)xmlSerializer.Deserialize(fs);
                }
            tasks[iter].Status_Task = true;
            using (FileStream fs = new FileStream(File_name, FileMode.Truncate))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Task>));
                xmlSerializer.Serialize(fs, tasks);
            }
            this.Close();
        }

        private void Delete_button_Click(object sender, RoutedEventArgs e)
        {
            bool check_xml = false;
            using (StreamReader fs = new StreamReader(File_name))
            {
                if (fs.ReadToEnd().Trim().Length > 0)
                {
                    check_xml = true;
                }
            }
            if (check_xml)
                using (FileStream fs = new FileStream(File_name, FileMode.OpenOrCreate))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Task>));
                    tasks = (List<Task>)xmlSerializer.Deserialize(fs);
                }
            tasks.RemoveAt(iter);
            using (FileStream fs = new FileStream(File_name, FileMode.Truncate))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Task>));
                xmlSerializer.Serialize(fs, tasks);
            }
            this.Close();
        }
    }
}

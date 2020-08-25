using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Xml.Serialization;

namespace task_board
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        string Urgent_Task_File_Name = @"C:\task board\UrgentTask.xml";
        string Coming_Days_Task_File_Name = @"C:\task board\ComingDaysTask.xml";
        string Next_Month_Task_File_Name = @"C:\task board\NextMonthTask.xml";
        private void Exit_Button(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Urgent_Task_Button(object sender, RoutedEventArgs e)
        {
            Urgent_task urgent_Task = new Urgent_task();
            urgent_Task.Owner = this;
            urgent_Task.WindowStartupLocation= WindowStartupLocation.CenterOwner;
            urgent_Task.Show();            
        }
        private void Add_task_button(object sender, RoutedEventArgs e)
        {
            Add_task_window add_Task = new Add_task_window();
            add_Task.Owner = this;
            add_Task.Add_task += Add_t_m;
            add_Task.Show();
        }
        public void Add_t_m(Task task)
        {
            List<Task> tasks = new List<Task>() { };
            bool check_xml = false;
            string File_name ="";            
            if(task.Type == Task.Type_task.urgent)
            {
                File_name = Urgent_Task_File_Name;
            }
            if (task.Type == Task.Type_task.coming_days)
            {
                File_name = Coming_Days_Task_File_Name;
            }
            if (task.Type == Task.Type_task.next_month)
            {
                File_name =Next_Month_Task_File_Name;
            }
            using (StreamReader fs = new StreamReader(File_name))
            {
                if (fs.ReadToEnd().Trim().Length > 0)
                {
                    check_xml = true;               
                }
            }
            if (check_xml)
            {
                using (FileStream fs = new FileStream(File_name, FileMode.OpenOrCreate))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Task>));
                    tasks = (List<Task>)xmlSerializer.Deserialize(fs);
                }
            }
            //десириализуем список из файл
            tasks.Add(task);
            using (FileStream fs = new FileStream(File_name, FileMode.OpenOrCreate))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Task>));
                xmlSerializer.Serialize(fs, tasks);            
            }
            //сериализуем все обратно
        }
        private void On_Development_Stage(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("On developmenent stage");
        }
        private void Task_coming_days_button(object sender, RoutedEventArgs e)
        {
            
        }
        public MainWindow()
        {
            InitializeComponent();
            string path = @"C:\task board";
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
            FileInfo fileInfo = new FileInfo(Urgent_Task_File_Name);
            if(!fileInfo.Exists)            
                fileInfo.Create();
            FileInfo fileInfo1 = new FileInfo(Coming_Days_Task_File_Name);
            if (!fileInfo1.Exists)
                fileInfo1.Create();
            FileInfo fileInfo2 = new FileInfo(Next_Month_Task_File_Name);
            if (!fileInfo2.Exists)
                fileInfo2.Create();
        }
    }
}

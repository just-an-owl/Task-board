using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;

namespace task_board
{
    public class Task
    {
        public enum Type_task { urgent, coming_days, next_month};
        public Type_task Type { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set;  }
        public bool Status_Task { get; set; }   
        public Task() { }
        public Task(string _name, string _text, DateTime dateTime, bool Status=false, Type_task type = Type_task.urgent)
        {
            Name = _name;
            Text = _text;
            Date = dateTime;
            Status_Task = Status;
            Type = type;
        }   
        
    }
}

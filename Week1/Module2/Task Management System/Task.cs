using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System
{
    public class Task
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string Status { get; set; }
        public Task? Next { get; set; }  

        public Task(int taskId, string taskName, string status)
        {
            TaskId = taskId;
            TaskName = taskName;
            Status = status;
            Next = null;
        }

        public override string ToString()
        {
            return $"TaskID: {TaskId}, Name: {TaskName}, Status: {Status}";
        }
    }
}

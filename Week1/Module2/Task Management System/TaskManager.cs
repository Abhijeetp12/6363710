using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System
{
    public class TaskManager
    {
        private Task? head;  

        public TaskManager()
        {
            head = null;
        }

        
        public void AddTask(Task newTask)
        {
            if (head == null)
            {
                head = newTask;
            }
            else
            {
                Task current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newTask;
            }
        }

        
        public Task? SearchTask(int taskId)
        {
            if (head == null) return null;
            Task? current = head;

            while (current != null)
            {
                if (current.TaskId == taskId)
                    return current;
                current = current.Next;
            }
            return null;
        }

      
        public void DeleteTask(int taskId)
        {
            if (head == null) return;

            if (head.TaskId == taskId)
            {
                head = head.Next;
                return;
            }

            Task current = head;
            while (current.Next != null && current.Next.TaskId != taskId)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
        }

      
        public void TraverseTasks()
        {
            Task? current = head;
            while (current != null)
            {
                Console.WriteLine(current);
                current = current.Next;
            }
        }
    }
}

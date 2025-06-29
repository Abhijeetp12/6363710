using System;

namespace Task_Management_System { 
class Program
{
    static void Main()
    {
        TaskManager manager = new TaskManager();

        manager.AddTask(new Task(1, "Design Database", "Pending"));
        manager.AddTask(new Task(2, "Build API", "In Progress"));
        manager.AddTask(new Task(3, "Test Application", "Pending"));

        Console.WriteLine("All Tasks:");
        manager.TraverseTasks();

        Console.WriteLine("\nSearching for Task ID 2:");
        var task = manager.SearchTask(2);
        Console.WriteLine(task != null ? task.ToString() : "Task not found");

        Console.WriteLine("\nDeleting Task ID 1...");
        manager.DeleteTask(1);

        Console.WriteLine("\nRemaining Tasks:");
        manager.TraverseTasks();
    }
}
}
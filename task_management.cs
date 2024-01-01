using System;
using System.Collections.Generic;
class TaskManager
{
    //Using a list to store tasks
    private List<TaskItem> taskList;
    //Using a stack to store completed tasks
    private Stack<TaskItem> completedTasks;
    private Queue<TaskItem> pendingTasks;

    //Using a dictionary to stpore tasks with unique ids
    private Dictionary<int, TaskItem> taskDictionary;

    public TaskManager()
    {
        taskList = new List<TaskItem>();
        completedTasks = new Stack<TaskItem>();
        pendingTasks = new Queue<TaskItem>();
        taskDictionary = new Dictionary<int, TaskItem>();
    }

    public void AddTask(string description, int priority)
    {
        TaskItem newTask = new TaskItem(description, priority);
        //Adding to the list
        taskList.Add(newTask);

        //Adding to the queus
        pendingTasks.Enqueue(newTask);

        //Adding dictionary
        int taskId = taskDictionary.Count + 1;
        taskDictionary.Add(taskId, newTask);
        Console.WriteLine("Task added with id" + newTask);
    }
    public void CompleteTask()
    {
        if (pendingTasks.Count > 0)
        {
            TaskItem completedTask = pendingTasks.Dequeue();

            //Adding to the stack
            completedTasks.Push(completedTask);
            Console.WriteLine("Task completed" + completedTask);
        }
        else
        {
            Console.WriteLine("No pending tasks");
        }
    }
    public void DisplayTasks()
    {
        Console.WriteLine("\n All tasks:");
        foreach (TaskItem task in taskList)
        {
            Console.WriteLine(task);
        }
        Console.WriteLine("\n Pending tasks:");
        foreach (TaskItem task in pendingTasks)
        {
            Console.WriteLine(task);
        }
        Console.WriteLine("\n Completed tasks:");
        foreach (TaskItem task in completedTasks)
        {
            Console.WriteLine(task);
        }

    }
}

class Program
{
    static void Main()
    {
        TaskManager taskManager = new TaskManager();
        taskManager.AddTask("Write report", 2);
        taskManager.AddTask("Pay bills", 1);
        taskManager.AddTask("Buy groceries", 3);

        //Displaying tasks
        taskManager.DisplayTasks();
        //Completing tasks
        taskManager.CompleteTask();

        //Displaying after completion
        taskManager.DisplayTasks();

    }
}
public class TaskItem
{
    public string Description
    {
        get;
    }
    public int Priority
    {
        get;
    }
    public TaskItem(string description, int priority)
    {
        Description = description;
        Priority = priority;
    }
    public override string ToString()
    {
        return $"{Priority} {Description}";
    }
}
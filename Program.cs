using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== Task Manager ==\n");

            TaskManager.ShowTasks();
            TaskManager.AddTask();
            TaskManager.DeleteTask();
        }
    }
}

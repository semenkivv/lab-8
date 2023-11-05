using System;
using System.Collections.Generic;

namespace Laba_7_V_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task("do work");
            Task task2 = new Task("do sleap");
            Task task3 = new Task("do laba 3");
            Task task4 = new Task("meet with manager");
            Task task5 = new Task("do relax");
            ListTasks listTasks = new ListTasks(task4, task3, task5);
            listTasks.AddElement(task1);
            listTasks.AddElement(task2);

            // Json 

            FileManagerListTasks.SerializationToJSON(listTasks.tasks, "ListTasks.json");

            List<Task> listTasksJson = FileManagerListTasks.DeserializationFromJSON("ListTasks.json");
            Console.WriteLine($"From (ListTasks.json)  :");
            foreach (Task task in listTasksJson)
            {
                Console.WriteLine(task);
                Console.WriteLine("------------------------");
            }
            Console.WriteLine("-------------------------------------------------------------------------------");

            // Bin 
            
            FileManagerListTasks.SerializationToBinary(listTasks.tasks, "ListTasks.bin");

            List<Task> listTasksBinary = FileManagerListTasks.DeserializationFromBinary("ListTasks.bin");
            Console.WriteLine($"From (ListTasks.bin)  :");
            foreach (Task task in listTasksBinary)
            {
                Console.WriteLine(task);
                Console.WriteLine("------------------------");
            }
        }
    }
}

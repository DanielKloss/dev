using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static ToDoList list = new ToDoList();

        static void Main()
        {
            while (true)
            {
                ViewMainMenu();
            }
        }

        private static void ViewMainMenu()
        {
            Console.WriteLine("1 - View List");
            Console.WriteLine("2 - Load List");
            Console.WriteLine("3 - Save List");
            Console.WriteLine("4 - Add Task To List");
            Console.WriteLine("5 - Delete Task From List");

            switch (Console.ReadLine())
            {
                case "1":
                    ViewList();
                    break;
                case "2":
                    LoadList();
                    break;
                case "3":
                    SaveList();
                    break;
                case "4":
                    AddToList();
                    break;
                case "5":
                    DeleteFromList();
                    break;
            }
        }

        private static void DeleteFromList()
        {
            Console.Clear();
            Console.WriteLine("Name of task to delete:");
            bool result = list.Remove(Console.ReadLine());

            if (result)
            {
                Console.WriteLine("Task Deleted");
            }
            else
            {
                Console.WriteLine("Task Dosen't Exist");
            }

            Console.WriteLine();
        }

        private static void AddToList()
        {
            Console.Clear();
            Console.WriteLine("Name of task to add:");
            list.Add(Console.ReadLine());
            Console.WriteLine("Task Added");
            Console.WriteLine();
        }

        private static void SaveList()
        {
            Console.Clear();
            Console.WriteLine("Specify path to save to:");
            bool result = list.SaveList(Console.ReadLine());

            if (result)
            {
                Console.WriteLine("List Saved");
            }
            else
            {
                Console.WriteLine("Couldn't save list, please check your path and try again.");
            }

            Console.WriteLine();
        }

        private static void LoadList()
        {
            Console.Clear();
            Console.WriteLine("Specify file path to load:");
            bool result = list.LoadList(Console.ReadLine());

            if (result)
            {
                Console.WriteLine("List Loaded");
            }
            else
            {
                Console.WriteLine("Couldn't load list, please check your path and try again.");
            }

            Console.WriteLine();
        }

        static void ViewList()
        {
            Console.Clear();

            foreach (string item in list.ToDos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}

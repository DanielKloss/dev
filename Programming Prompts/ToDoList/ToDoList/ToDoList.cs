using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class ToDoList
    {
        public List<string> ToDos = new List<string>();

        public bool LoadList(string path)
        {
            string[] fileLines;

            try
            {
                fileLines = File.ReadAllLines(path);
            }
            catch (Exception)
            {
                return false;
            }

            foreach (string fileLine in fileLines)
            {
                ToDos.Add(fileLine.Trim());
            }

            return true;
        }

        public bool SaveList(string path)
        {
            try
            {
                File.WriteAllLines(path, ToDos);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public void Add(string todo)
        {
            ToDos.Add(todo);
        }

        public bool Remove(string todo)
        {
            if (ToDos.Contains(todo))
            {
                ToDos.RemoveAll(t => t == todo);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

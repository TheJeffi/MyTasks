using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTasks.Models
{
    public class MyTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Ended { get; set; }

        public MyTask(string name, string description, DateTime created, DateTime ended)
        {
            //TODO : Реализовать логику проверки данных
            Name = name;
            Description = description;
            Created = created;
            Ended = ended;
        }

        public MyTask() : this("noname", "nodescription", DateTime.Now, DateTime.Now)
        {

        }

        private bool StringValidation(string str)
        {
            if (str == null || str == String.Empty)
                return false;
            return true;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}

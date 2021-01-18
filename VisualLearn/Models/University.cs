using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace root.Models
{
    public class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public University()
        {
            Console.WriteLine("Userverity instance");
        }
        public University(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public void GetInfo()
        {
            Console.WriteLine($"{Id}");
            Console.WriteLine($"{Name}");
        }
    }
}

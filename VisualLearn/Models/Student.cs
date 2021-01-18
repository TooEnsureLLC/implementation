using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace root.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        // Foreign Key
        public int UnerversityId { get; set; }

        public Student(int id, string name, string gender, int age, int universityId)
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.UnerversityId = universityId;
        }

        public void GetInfo()
        {
            Console.WriteLine("===========================START============================");
            Console.WriteLine($"SSN: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Unerversity Id: {UnerversityId}");
            Console.WriteLine("=============================END==========================");
        }
    }
}

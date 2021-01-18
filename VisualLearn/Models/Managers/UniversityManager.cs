using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace root.Models.Managers
{
    public class UniversityManager
    {
        public List<University> unerversities;
        public List<Student> students;

        public UniversityManager()
        {
            unerversities = new List<University>();
            students = new List<Student>();
        }
        
        public void GetGender(string gender)
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == gender select student;
            Console.WriteLine("Male - students");

            foreach (Student student in maleStudents)
            {
                student.GetInfo();
            }
        }

        public void GetAges(int num1 = 18, int num2 = 20)
        {
            IEnumerable<Student> getAges = from student in students where (student.Age >= num1 && student.Age <= num2) select student;
            Console.WriteLine($"Ages from {num1} - {num2}");

            foreach (Student student in getAges)
            {
                student.GetInfo();
            }
        }
    }
}

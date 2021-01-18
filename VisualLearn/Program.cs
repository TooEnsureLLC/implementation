using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using root.Models;
using root.Models.Managers;

namespace root
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            University university1 = new University(1,"Yale");
            University university2 = new University(2,"Standford");

            Student student1 = new Student(1,"Tim","male",18, 1);
            Student student2 = new Student(2, "Mike", "male", 18, 2);
            Student student3 = new Student(3, "Kim", "male", 28, 1);
            Student student4 = new Student(4, "Shawn", "female", 23, 2);
            Student student5 = new Student(5, "Bob", "male", 23, 1);
            Student student6 = new Student(6, "Billy", "male", 25, 2);
            Student student7 = new Student(7, "Shara", "female", 18, 1);
            Student student8 = new Student(8, "Nick", "male", 17, 2);
            Student student9 = new Student(9, "Nicky", "female", 40, 1);
            Student student10 = new Student(10, "Quan", "male", 33, 2);

            UniversityManager universityManager = new UniversityManager();
            // Managing list of universities
            universityManager.unerversities.Add(university1);
            universityManager.unerversities.Add(university2);
            // Managing list of students
            universityManager.students.Add(student1);
            universityManager.students.Add(student2);
            universityManager.students.Add(student3);
            universityManager.students.Add(student4);
            universityManager.students.Add(student5);
            universityManager.students.Add(student6);
            universityManager.students.Add(student7);
            universityManager.students.Add(student8);
            universityManager.students.Add(student9);
            universityManager.students.Add(student10);

            universityManager.GetAges(20, 25);
        }

        
    }
}

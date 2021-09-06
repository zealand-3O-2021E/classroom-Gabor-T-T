using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            

            ClassRoom c1 = new ClassRoom();

            c1.ClassName = "A.2134";
            c1.ClassList = new List<Student>();
            c1.Semester = new DateTime(2021, 08, 30);


            Student s1= new Student($"Gabor",11,03);
            Student s2 = new Student($"Dávid", 11, 21);
            Student s3 = new Student($"Tony", 09, 03);
            Student s4 = new Student($"George", 08, 18);
            

            c1.ClassList.Add(s1);
            c1.ClassList.Add(s2);
            c1.ClassList.Add(s3);
            c1.ClassList.Add(s4);


            Console.WriteLine($"The class name is: {c1.ClassName} and the semester started at: {c1.Semester}");

           Student.Season();
            
            Console.ReadKey();




        }
    }
}

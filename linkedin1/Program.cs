
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace linkedin1
{
    class Program
    {
        static void Main(string[] args)
        {
            // StudentManager studentmanager = new StudentManager();
            // studentmanager.GetDetails();
            List<StudentManager2> student = new List<StudentManager2>();
            bool adding = true;
            while (adding)
            {
                StudentManager2 student1 = new StudentManager2();
                student1.getDetails();
                student.Add(student1);
                StudentManager2.count++;
                Console.WriteLine("Student Count: {0}", StudentManager2.count);
                Console.WriteLine("Do you wish to continue y/n?");
                if (Console.ReadLine() != "y")
                    adding = false;
            }
            foreach (var students in student)
            {
                Console.WriteLine("Name: {0}  Grade: {1}  Birthday: {2}  Address: {3}  Phone: {4}", students.name, students.grade,students.birthday,students.address,students.phone);
               

            }
            Console.ReadLine();

        }
       
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDB
{
    class StudentManager
    {

        static List<string> studentName = new List<string>();
        static List<int> studentGrade = new List<int>();
        public void GetDetails()
        {

            Console.WriteLine("Enter student name");
            studentName.Add(Console.ReadLine());
            Console.WriteLine("Enter student grade");

            studentGrade.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine("Do you want to add more? y/n");
            var choice = Console.ReadLine();
            if (choice == "y")
            {
                GetDetails();
            }
            else
            {

                Display();
                return;
            }


        }
        public static void Display()
        {

            for (int i = 0; i < studentName.Count; i++)
            {

                Console.WriteLine("Student name: {0} \t Grade:{1}", studentName[i], studentGrade[i]);
            }
            Console.ReadLine();
        }
    }
}

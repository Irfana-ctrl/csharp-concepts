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
            /* for (int i = 1; i <= 10; i++)
                 Console.WriteLine(i);
             for (int a = 10; a > 0; a--)
                 Console.WriteLine(a);*/
            /*
             int[] studentGrade = new int[] { 12, 25, 88, 96, 100 };
             for (int i = 0; i < studentGrade.Length; i++)
             {
                 Console.WriteLine(studentGrade[i]);

             }
             Console.ReadLine();*/
            Console.WriteLine("How many students to enter");
            var studentCount = int.Parse(Console.ReadLine());

            var studentName = new string[studentCount];
            var studentGrade = new int[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Enter the name of the student");
                studentName[i] = Console.ReadLine();
                Console.WriteLine("Enter the grade");
                studentGrade[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < studentCount; i++)
            {

                Console.WriteLine("Student name: {0} \t Grade:{1}", studentName[i], studentGrade[i]);
               
            }
            Console.ReadLine();

            }
        }
    }


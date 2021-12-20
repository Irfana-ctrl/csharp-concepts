using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedin1
{
    class StudentManager2
    {
        public string name { get; set; }
        public  int grade { get; set; }
        public string birthday { get; set; }
        public string address { get; set; }
        public int phone { get; set; }
        public static int count { get; set; }
        public void getDetails()
        {
            Console.WriteLine("Enter student name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter student grade: ");
           int.TryParse(Console.ReadLine(),out int result1);
              grade = result1;  
            Console.WriteLine("Enter student birthday: ");
            birthday =Console.ReadLine();
            Console.WriteLine("Enter student address: ");
            address = Console.ReadLine();
            Console.WriteLine("Enter student phone: ");
            int.TryParse(Console.ReadLine(),out int result2);
            phone = result2;



        }
    
}
}

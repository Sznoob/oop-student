using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class StudentDetails
    {
        Student numb1 = new Student("Pavol", "Smith", 8.5f);
        Student numb2 = new Student(13, "Alex ", "Leeroy", 6.3f);

        public void PrintData()
        {
            Console.WriteLine("{0} {1}'s GPA is {2}", numb1.FirstName, numb1.LastName, numb1.GPA);
            Console.WriteLine("Student ID is {0}. {1} {2}'s GPA is {3}", numb2.StudentId, numb2.FirstName, numb2.LastName, numb2.GPA);
        }  
        
        

    }
}

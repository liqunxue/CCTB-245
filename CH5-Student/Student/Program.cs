using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            DayTimeStudent student1= new DayTimeStudent("Liza", "780-1111111", "section a", "locker1");
            student1.DisplayStudent();

            Student temp = new Student();
            temp = new Student();
            temp = new Student();
            
            EveningStudent student2 = new EveningStudent("John", "780-2222222", "room 101", "computer");

            student2.DisplayStudent();
            temp.DisplayStudent();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class DayTimeStudent : Student
    {
        public string Section { get; set; }
        public string Locker { get; set; }

        public DayTimeStudent(string name, string phonenumber, string section, string locker) : base(name, phonenumber)
        {
            Console.WriteLine("<-DayTimeStudent - Greedy Constructor->");
            //Id = id;
            //Name = name;
            //PhoneNumber = phonenumber;
            Section = section;
            Locker = locker;
        }

        public override void DisplayStudent()
        {
            base.DisplayStudent();
            Console.WriteLine("Daytime student's section is {0} and locker is {1}", Section, Locker);
        }
    }
}

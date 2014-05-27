using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class EveningStudent : Student
    {
        public string RoomNumber { get; set; }
        public string CourseName { get; set; }

        public EveningStudent(string name, string phonenumber, string roomnumber, string coursename) : base(name, phonenumber)
        {
            Console.WriteLine("<-EveningStudent - Greedy Constructor->");
            //Id = id;
            //Name = name;
            //PhoneNumber = phonenumber;
            RoomNumber = roomnumber;
            CourseName = coursename;
        }

        public override void DisplayStudent()
        {
            Console.WriteLine("Student {0} name is {1} and phone number is {2}, Evening Student's room number is {3} and Course name is {4}", Id, Name, PhoneNumber, RoomNumber, CourseName);
        }

    }
}

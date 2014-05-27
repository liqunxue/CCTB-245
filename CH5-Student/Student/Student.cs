using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Student
    {
        //static field for the last generated student ID
        private static int _LastUsedID = 20140001; // setting an initial value 
        public int Id { get; private set; }
        public string Name {get; protected set;}
        public string PhoneNumber { get; protected set; }

        public Student()
        {
            Console.WriteLine("<-Student - Parameterless Constructor->");
            _LastUsedID++;
            Id = _LastUsedID;
        }
        public Student(string name, string phonenumber) : this()
        {
            // TODO: Code the body of the constructor
            Console.WriteLine("<-Student - Greedy Constructor->");
            //id = Id;
            name = Name;
            phonenumber = PhoneNumber;
        }

        public virtual void DisplayStudent()
        {
            // TODO: Code the body of this method
            Console.WriteLine("Student {0} name is {1} and phone number is {2}", Id, Name, PhoneNumber);
        }
    }
}

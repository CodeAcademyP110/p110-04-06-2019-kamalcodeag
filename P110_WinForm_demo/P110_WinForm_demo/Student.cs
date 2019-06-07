using System;

namespace P110_WinForm_demo
{
    public class Student
    {
        private static int _id = 1;

        public Student()
        {
            Id = new string('0', 4 - _id.ToString().Length) + _id.ToString();
            _id++;
        }

        public Student(string fname, string lname) : this()
        {
            Firstname = fname;
            Lastname = lname;
        }

        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public string Fullname { get { return $"{Firstname} {Lastname}"; } }

        public override string ToString()
        {
            return $"{Fullname} {Email} {DateTime.Now.Year - Birthdate.Year} age";
        }
    }
}

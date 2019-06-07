using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P110_WinForm_demo
{
    public static class P110
    {
        private readonly static List<Student> _students;

        static P110()
        {
            _students = new List<Student>
            {
                new Student { Firstname = "Ilkin", Lastname = "Sardarov", Email = "ilkin@code.edu.az", Birthdate = new DateTime(1994, 10, 19) },
                new Student { Firstname = "Perviz", Lastname = "Mixcanov", Email = "mix@code.edu.az", Birthdate = new DateTime(1996, 3, 20) },
                new Student { Firstname = "Elmar", Lastname = "Ibrahimli", Email = "mar@code.edu.az", Birthdate = new DateTime(1999, 3, 30) }
            };
        }

        public static List<Student> GetStudents() => _students;

        public static void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public static bool DeleteStudentById(string id)
        {
            for (int i = 0; i < _students.Count; i++)
            {
                if(_students[i].Id == id)
                {
                    _students.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        public static Student GetStudentById(string id)
        {
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i].Id == id)
                {
                    return _students[i];
                }
            }

            return null;
        }
    }
}

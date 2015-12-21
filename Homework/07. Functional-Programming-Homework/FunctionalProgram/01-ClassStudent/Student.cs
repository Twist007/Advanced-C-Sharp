
using System.Collections.Generic;

namespace ClassStudentData
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string FacultyNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public IList<int> Marks { get; set; }
        public int GroupNumber { get; set; }


        public Student(string fname, string lname, int age, string facultyNumber, string phone, string email, IList<int> marks, int groupNumber)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;

        }

    }
}

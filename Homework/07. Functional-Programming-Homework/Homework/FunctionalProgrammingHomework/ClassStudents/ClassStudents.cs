using System.Collections.Generic;

namespace ClassStudents
{
    public class Students
    {
        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string FacultyNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        //Default Constructor
        public Students() { }

        //Constructor with params
        public Students(string firstName, string lastName,
                        int age,
                        string facultyNumber,
                        string phone,
                        string email,
                        List<int> marks,
                        int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        //ToString() override to print the class properties
        public override string ToString()
        {
            return ($"{FirstName} {LastName} \nAge: {Age} \nEmail: {Email} \nPhone: {Phone} \nFaculty Number: {FacultyNumber} \nMarks: {string.Join(", ", this.Marks)} \nGroup Number: {GroupNumber} \n");
        }

        public string PrintPersonalInfo()
        {
            return ($"{FirstName} {LastName} {Age}");
        }
    }

}

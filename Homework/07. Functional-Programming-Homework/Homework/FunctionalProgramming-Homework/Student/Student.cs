using System;
using System.Collections.Generic;

namespace Student
{
    public class Student  
    {
        // This is the solution of "Problem 1.	Class Student".
        // The list with the students is in the "StudentMain" class.

        public string FirstName;
        public string LastName;
        public byte Age;
        public uint FacultyNumber;
        public string Phone;
        public string Email;
        public IList<int> Marks;
        public int GroupNumber;
        public string GroupName; //This is for "Problem 11"
        
        public Student(string firstName, string lastName, byte age, uint facNumber, string phone, string email,IList<int> marks,int groupNumber,string groupName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
            this.GroupName = groupName;
        }

    }
}

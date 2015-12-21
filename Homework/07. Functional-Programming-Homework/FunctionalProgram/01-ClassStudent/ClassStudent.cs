//Create a class Student with properties FirstName, LastName, Age, FacultyNumber, Phone, Email, Marks (IList<int>), GroupNumber. Create a List<Student> with sample students. These students will be used for the next few tasks.


using ClassStudentData;

class ClassStudent
{
    static void Main()
    {
        StudentsData data = new StudentsData();

        data.Students.PrintInfo();

    }

}


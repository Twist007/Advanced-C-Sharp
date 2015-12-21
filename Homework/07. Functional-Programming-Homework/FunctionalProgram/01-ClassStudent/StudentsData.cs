
using System.Collections.Generic;

namespace ClassStudentData
{
    public class StudentsData
    {
        public List<Student> Students = CreateStudentsData();

        public static List<Student> CreateStudentsData()
        {
            var students = new List<Student>()
           {
               new Student("Pesho", "Ivanov", 18, "121214", "+359 2 341 5232 ", "peshooy@gmail.com",
                   new List<int>() {2, 3, 4, 5, 6}, 2),
               new Student("Ivan", "Peshev", 19, "121212", "+3592520427", "Inav@abv.bg",
                   new List<int>() {6,4,5,2,3,3}, 3),
               new Student("Dragan", "Nikolov", 20, "121215", "0884242452", "draganov@gmail.com",
                   new List<int>() {2, 3, 2,4,3,1, 5, 6}, 2),
                new Student("Niki", "Draganov", 20, "121218", "088325235245", "Niko@gmail.com",
                   new List<int>() {6, 6, 6, 5, 6}, 2),
                new Student("Sasho", "Sashov", 22, "121214", "02 9423 234", "sashov@yahoo.com",
                   new List<int>() {2,2, 2, 3, 3, 4, 5, 6}, 1)

           };

            return students;
        }
    }
}

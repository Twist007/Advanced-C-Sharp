using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudent
{
    public class StudentsDirectory
    {
        public List<Student> Students = CreateStudentDirectory();
        public static List<Student> CreateStudentDirectory()
        {
            var students = new List<Student>
            {
                new Student("Ivan", "Ivanov",18,"8012131","021234","",new List<int> {5, 3, 5, 6},1),
                new Student("Pesho", "Peshev",18,"801242","+3592321638","peshev@abv.bg",new List<int> {5, 2, 5, 6},1),
                new Student("Andrei", "Petkov",19,"801253","07113","petkov@abv.bg",new List<int> {5, 2, 2, 6},2),
                new Student("Goshko", "Goskov",19,"801214","083545","goshov@gmail.com",new List<int> {5, 2, 5, 5},2),
                new Student("Mariika", "Marieva",20,"801275","+359 2","niama@ght.gh",new List<int> {6, 2, 6, 4},1),
                new Student("Rositza", "Toseva",21,"801215","112345","pakmail@abv.bg",new List<int> {4, 2, 6, 3},2),
                new Student("Ivan", "Petkov",36,"803114","524354","zashto@hotmail.com",new List<int> {6, 2, 6, 6},3),
            };
            return students;
        }
    }
}

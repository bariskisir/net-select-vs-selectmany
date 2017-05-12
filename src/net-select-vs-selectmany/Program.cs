using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace net_select_vs_selectmany
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentList = GenerateRandomStudentList();
            // SelectMany returns List<Course>
            List<Course> selectManyCourses = studentList.SelectMany(x => x.Courses).ToList();
            // Select returns List<List<Course>>
            List<List<Course>> selectCourses = studentList.Select(x => x.Courses).ToList();
            //
            Console.ReadKey();
        }
        public static List<Student> GenerateRandomStudentList()
        {
            var studentList = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                studentList.Add(GenerateRandomStudent());
            }
            return studentList;
        }
        public static Student GenerateRandomStudent()
        {
            var student = new Student();
            student.Name = GenerateRandomString(10);
            student.Courses = GenerateRandomCourseList();
            return student;
        }
        public static List<Course> GenerateRandomCourseList()
        {
            var courseList = new List<Course>();
            for (int i = 0; i < 10; i++)
            {
                courseList.Add(GenerateRandomCourse());
            }
            return courseList;
        }
        public static Course GenerateRandomCourse()
        {
            var course = new Course();
            course.CourseName = GenerateRandomString(5);
            return course;
        }
        private static Random random = new Random();
        public static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}

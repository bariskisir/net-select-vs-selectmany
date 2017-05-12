using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace net_select_vs_selectmany
{
    class Student
    {
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
        public Student()
        {
            this.Courses = new List<Course>();
        }
    }
}

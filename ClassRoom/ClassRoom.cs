using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ClassRoom
    {
        private string _className;
        private List<Student> _classList;
        private DateTime _semesterStart;

        public ClassRoom()
        {
            ClassName = _className;
            ClassList = _classList;
            Semester = _semesterStart;
        }

        public string ClassName { get; set; }

        public List<Student> ClassList { get; set; }

        public DateTime Semester { get; set; }


    }
}

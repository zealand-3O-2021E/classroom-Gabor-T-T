using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Student
    {
        private string _name;
        private int _birthMonth;
        private int _birthday;

        public Student(string name, int birthMonth, int birthday)
        {
            name = _name;
            birthMonth = _birthMonth;
            birthday = _birthday;
        }
        public string Name
        {
            get { return _name; }
            set { value = _name; }
        }

        public int BithMonth
        {
            get { return _birthMonth; }
            set { value = _birthMonth; }
        }

        public int Birthday
        {
            get { return _birthday; }
            set { value = _birthday; }
        }

    }
}

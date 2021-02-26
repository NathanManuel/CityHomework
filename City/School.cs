using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    public class School
    {
        private string name;
        private int nrStudents;
        public School(string name, int nrStudents)
        {
            this.name = name;
            this.nrStudents = nrStudents;
        }

        override
    public string ToString()
        {
            return "The school is called " + this.name + " and has a total of " + this.nrStudents + " students";
        }
    }
}

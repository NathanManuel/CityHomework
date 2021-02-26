using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    public class School
    {
        private string name;
        private int nrStudents;
        private Street s;
        public School(string name, int nrStudents, Street s)
        {
            this.name = name;
            this.nrStudents = nrStudents;
            this.s = s;
        }

        override
    public string ToString()
        {
            return "The school is called " + this.name + " and has a total of " + this.nrStudents + " students \nThe school is on the " + this.s.getStreet() + " street" ;
        }
    }
}

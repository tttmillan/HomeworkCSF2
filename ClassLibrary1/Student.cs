using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student
    {
        //Fields

        private string _firstName;
        private string _lastName;

        //Properties

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        //ctors

        public Student() { }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //method

        public override string ToString()
        {
            return string.Format("Student\n" +
                "First Name: {0}\n" +
                "Last Name: {1}\n",
                FirstName,
                LastName);
        }
        
    }//end class

}//end namespace

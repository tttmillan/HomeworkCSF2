using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Login
    {
        //Fields

        private string _username;
        private string _password;


        //Properties

        public string Userame
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }


        //ctors
        //default ctor

        public Login() { }

            //fullyqualified ctor

        public Login(string username, string password)
        {
            Userame = username;
            Password = password;
        }


        //method

        public override string ToString()
        {
            return string.Format("Your Username is {0} and your Password is {1}", Userame, Password);
        }
    }
}

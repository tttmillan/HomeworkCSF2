using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.FirstName = "Han";
            s1.LastName = "Solo";
            Console.WriteLine(s1);


            Vehicle v1 = new Vehicle("Chevrolet", "Bel Air", 1957, 3273);
            Console.WriteLine(v1);

            Login l1 = new Login();
            l1.Userame = "Chewbacca";
            l1.Password = "Millennium Falcon";
            Console.WriteLine(l1);

            ContactInfo c1 = new ContactInfo("P.O. Box 49344", "Los Angles", "California", "90049", "323-461-0100", "NA");
            Console.WriteLine(c1);

        }//end Main()

    }//end class

}//end namespace

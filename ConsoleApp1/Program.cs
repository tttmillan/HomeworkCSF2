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

            Login log1 = new Login();
            log1.Userame = "Chewbacca";
            log1.Password = "Millennium Falcon";
            Console.WriteLine(log1);

            ContactInfo c1 = new ContactInfo("P.O. Box 49344", "Los Angles", "California", "90049", "323-461-0100", "NA");
            Console.WriteLine(c1);

            Customer cus1 = new Customer("0001", "Harrison", "Ford", c1);
            Console.WriteLine(cus1);

            CreditCardAccount cc1 = new CreditCardAccount( 1, cus1, 1000m, false, 7);
            Console.WriteLine(cc1);

            Book bk1 = new Book("Atlas Shrugged", "Ayn Rand", 1168);
            Console.WriteLine(bk1);


            List<Book> books = new List<Book>() { bk1 };


            Library lib1 = new Library(books, "Price James Library", "104 E. Morgan Street", "Tipton", "MO", "65081");
            Console.WriteLine(lib1);

            Song song1 = new Song("Mase", "Welcome Back", 274);
            Console.WriteLine(song1);
               

        }//end Main()

    }//end class

}//end namespace

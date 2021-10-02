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

            Song song1 = new Song("Journey", "Don't Stop Believin", 251);
            Console.WriteLine(song1);
            Song song2 = new Song("Journey", "Faithfully", 266);
            Song song3 = new Song("Journey", "Anyway You Want It", 250);
            Song song4 = new Song("Journey", "Open Arms", 200);
            Song song5 = new Song("Journey", "Feeling That Way", 211);

            Song[] tracks = { song1, song2, song3, song4, song5 };

            Artist journey = new Artist(song1, "Journey's Greatest Hits", "Rock");
            Console.WriteLine(journey);

            MotorHome mh1 = new MotorHome("Thor Motor Coach", "Daybreak 22GO", 2020, 8000, 3);
            Console.WriteLine(mh1);





        }//end Main()

    }//end class

}//end namespace

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Book
    {
        //Fields

        //Prop
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }



        //Ctor


        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }



        //Methods


        public override string ToString()
        {
            return string.Format($"\nTitle: {Title}\n" +
                $"Author: {Author}\n" +
                $"Number of Pages {NumberOfPages}");
        }


                                    
    }//end class

}//end namespace

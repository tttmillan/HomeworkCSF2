using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
     public class Song
    {
        //Fields

        //Prop
        public string Artist { get; set; }
        public string Title { get; set; }
        public int LengthInSeconds { get; set; }


        //Ctor
        public Song()
        {

        }

        public Song(string artist, string title, int lengthInSeconds)
        {
            Artist = artist;
            Title = title;
            LengthInSeconds = lengthInSeconds;
        }


        //Method


        public override string ToString()
        {
            return string.Format($"The song {Title} by {Artist} is {LengthInSeconds} seconds long.");
        }

                                    
    }//end class

}//end namespace

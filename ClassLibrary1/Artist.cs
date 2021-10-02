using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Artist
    {
        //Fields

        //Prop
        public Song Tracks { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }


        //Ctor


        public Artist(Song tracks, string title, string genre)
        {
            Tracks = tracks;
            Title = title;
            Genre = genre;
        }


        //Method


        public override string ToString()
        {
            return string.Format($"If you want {Genre} from {Title} here is their {Tracks}.");
        }














    }//end class

}//end namespace

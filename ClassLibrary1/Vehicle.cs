using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Vehicle
    {
        //Fields


        private string _make;
        private string _model;
        private int _year;
        private float _weight;


        //Properties


        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public float Weight
        {
            get { return _weight; }
            set
            {
                if (value > 1000)
                {
                    _weight = value;
                }
                else
                {
                    _weight = 0;
                }
            }
        }


        //ctors

            //default ctor

        public Vehicle() { }

            //fullyqualified ctor

        public Vehicle(string make, string model, int year, float weight)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
        }


        //method

        public override string ToString()
        {
            return string.Format("The Weight of a {0} {1} {2} is {3} lbs.", Year, Make, Model, Weight);
        }


    }
}

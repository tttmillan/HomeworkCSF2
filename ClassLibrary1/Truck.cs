using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Truck : Vehicle
    {
        //Fields
        //Prop
        public float LoadCapacityLbs { get; set; }


        //Ctor


        public Truck (string make, string model, int year, float weight, float loadCapcityLbs) : base(make, model, year, weight)
        {
            LoadCapacityLbs = loadCapcityLbs;
        }


        //Methods


        public override string ToString()
        {
            return base.ToString() + "This Trucks load Capacity is " + LoadCapacityLbs + " lbs.";
        }


    }//end class

}//end namespace

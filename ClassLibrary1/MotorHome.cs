using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MotorHome : Vehicle
    {
        //Fields

        //Prop
        public int NumberOfBeds { get; set; }

        public MotorHome(string make, string model, int year, float weight, int numberOfBeds) : base(make,model,year,weight)
        {
            NumberOfBeds = numberOfBeds;
        }


        //Method


        public override string ToString()
        {
            return base.ToString() + "MotorHome with " + NumberOfBeds + " number of beds";
        }
    }//end class
    
}//end namespace

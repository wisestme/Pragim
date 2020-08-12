using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim.Services
{
    public class VehicleInheritance
    {
        public string Type;
        public string EngineNumber;
        public string Color;
        public string Transmission;
        public string NumberOfTyres;

        public void VehicleDetails()
        {
            Console.WriteLine("Your vehicle is a {0} {1} with engine number {2}", Color, Type, EngineNumber);
        }
    }

    public class Car : VehicleInheritance
    {
        public string DoorsNumber;

        //public void VehicleDetails()
        //{
        //    Console.WriteLine("Your Vehicle is a {0}", Type);
        //}
    }
}

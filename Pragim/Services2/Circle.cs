using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim.Services2
{
   public class Circle
    {
        float PI = 3.142f;
        int _Radius;

        public Circle(int Radius)
        {
            this._Radius = Radius;
        }

        public float CalculateArea()
        {
            return this.PI * this._Radius * this._Radius;
        }
    }

    public class Compute
    {
        public static void Evaluate()
        {
            Circle circle = new Circle(6);
            float result = circle.CalculateArea();
            Console.WriteLine(result);
        }
        
    }
}

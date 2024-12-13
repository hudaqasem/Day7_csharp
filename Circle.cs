using Day7.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.classes
{
    internal class Circle1 : IShape
    {
        #region property
        public double Radius { get; set; }
        public double Area { get{ return 3.14 * Radius * Radius; } }
        #endregion

        #region constructor
        public Circle1(double r)
        {
            Radius = r;
        }
        #endregion

        #region Method
        public void Draw()
        {
            Console.WriteLine($"Circle radius : {Radius}");
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Circle radius : {Radius} , Area : {Area}");
        } 
        #endregion

    }
}

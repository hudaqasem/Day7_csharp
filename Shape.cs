using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Inheritance
{
    internal abstract class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Imagine it :)");
        }
        // abstract method must be in abstract class 
        public abstract double CalculateArea();

    }
}

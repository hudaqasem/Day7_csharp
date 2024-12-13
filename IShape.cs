using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Interfaces
{
    internal interface IShape
    {
        public double Area { get;}
        public void Draw();

        public void PrintDetails()
        {
            Console.WriteLine($"Area : {Area}");
        }
    }
}

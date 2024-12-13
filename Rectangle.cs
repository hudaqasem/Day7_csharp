using Day7.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.classes
{
    internal class Rectangle1 : IShape
    {

        #region properties 
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area { get { return Width * Height; } }

        #endregion

        #region constructor
        public Rectangle1()
        {
            
        }
        public Rectangle1(double width, double height)
        {
            Width = width;
            Height = height;
        }
        #endregion

        #region Method
        public void Draw()
        {
            Console.WriteLine($"rectangle width : {Width} and height : {Height}");
        }
        #endregion

    }
}

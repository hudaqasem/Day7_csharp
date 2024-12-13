using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Inheritance
{
    internal class Rectangle2:Shape
    {
        #region properties 
        public double Width { get; set; }
        public double Height { get; set; }
        #endregion

        #region constructors
        public Rectangle2()
        {

        }
        public Rectangle2(double width, double height)
        {
            Width = width;
            Height = height;
        }
        #endregion

        #region Method
        public override void Draw()
        {
            base.Draw();
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"Width : {Width} , Height : {Height} , Area : {CalculateArea()}";
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Inheritance
{
    internal class Parent
    {
        #region properties
        public int X { get; set; }
        public int Y { get; set; }

        #endregion

        #region constructor
        public Parent() { }
        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"({X},{Y})";
        }
        public virtual int Product()
        {
            return X * Y;
        }
        #endregion


    }
}

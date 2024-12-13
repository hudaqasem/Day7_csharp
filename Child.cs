using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Inheritance
{
    internal class Child : Parent
    {
        #region properties
        public int Z { get; set; }
        #endregion

        #region constructors
        public Child() { }
        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
        #endregion

        #region Method

        //public new int Product()
        //{
        //    return X * Y * Z;
        //}
        public override int Product()
        {
            return base.Product() * Z;
        }
        public override string ToString()
        {
            return $"({X},{Y},{Z})";
        } 
        #endregion

    }
}

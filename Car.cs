using Day7.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.classes
{
    internal class Car : IMovable
    {
        #region Properties
        public int Id { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        #endregion

        #region Constructors
        
        public Car(int id)
        {
            Id = id;
            Brand = "BMW";
            Price = 6000000;
        }
        public Car(int id, string brand)
        {
            Id = id;
            Brand = brand;
            Price = 4000000;
        }
        public Car(int id, string brand, double prics)
        {
            Id = id;
            Brand = brand;
            Price = prics;
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"CarID : {Id} , Brand : {Brand} , Price : {Price}";
        }
        public void Move()
        {
            Console.WriteLine("Car is moving now :) ");
        }
        #endregion
    }
}

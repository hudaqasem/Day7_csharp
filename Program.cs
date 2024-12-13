using Day7.Inheritance;
using Day7.Interfaces;
using System.Drawing;
using Day7.classes;

namespace Day7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Car
            //Car C1 = new Car();
            //Console.WriteLine(C1);
            //Car C2 = new Car(1);
            //Console.WriteLine(C2);
            //Car C3 = new Car(2 , "Ferrari");
            //Console.WriteLine(C3);
            //Car C4 = new Car(3, "Kia", 800000);
            //Console.WriteLine(C4); 
            #endregion

            //-------------------------------

            #region Function overloading Sum()
            //Calculator C = new Calculator();
            //Console.WriteLine($"Sum of two integers : {C.Sum(1,1)}");
            //Console.WriteLine($"Sum of three integers : {C.Sum(1,1,2)}");
            //Console.WriteLine($"Sum of two doubles : {C.Sum(2.5,1.5)}");

            #endregion

            //----------------------------------

            #region Inheritance Parent & Child
            //Child Ch = new Child(5,10,5);
            //Console.WriteLine(Ch.X);
            //Console.WriteLine(Ch.Product());

            ////cat is an animal
            //Parent P = Ch;
            ////Console.WriteLine(P.Product()); // 50 new => Call parent 
            //Console.WriteLine(P.Product()); // 250 override => Call Child 
            #endregion

            //--------------------------------------

            #region Shape Interface

            //Rectangle1 R = new Rectangle1(5, 5);
            //Console.WriteLine(R.Area);

            ////---------

            //Circle1 C = new Circle1(2);
            //C.PrintDetails();

            #endregion

            //--------------------------------------

            #region IMovable

            //IMovable C = new Car(5);
            //C.Move(); 
            #endregion

            //--------------------------------------

            #region Multiple Interface
            //File1 F1 = new File1();
            //F1.Write();
            //F1.Read();

            //IWritable WF = new File1(); // has only write fun 
            //WF.Write();

            #endregion

            //--------------------------------------

            #region Shape Interitance
            //Rectangle2 R = new Rectangle2(2, 4);
            //R.Draw();
            //Console.WriteLine(R.CalculateArea());
            //Console.WriteLine(R); 
            #endregion

            //--------------------------------------

            



        }
    }
}

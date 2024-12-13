using Day7.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.classes
{
    internal class File1 : IWritable , IReadable
    {
        public void Write() 
        {
            Console.WriteLine("Write File");
        }
        public void Read() 
        {
            Console.WriteLine("Read File");
        }

    }
}

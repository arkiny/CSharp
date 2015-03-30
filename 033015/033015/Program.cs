// Namespace should be declared in the class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033015
{
    class MyProgram
    {
        // Entry Point should be exist only one.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Shitty BullShit World");
        }
    }
    class Program
    {
        // Two Entry Point will make compile Error
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello Shitty BullShit World");
        //}
    }
}

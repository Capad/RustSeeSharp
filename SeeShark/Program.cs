using System;
using System.Runtime.InteropServices;


namespace SeeShark // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var addedNumbers = add_numbers(10, 5);
            Console.WriteLine(addedNumbers);
            Console.ReadLine();
        }

        [DllImport("rusted_sea.dll")]
        private static extern Int32 add_numbers(Int32 arg1, Int32 arg2);
    }
}
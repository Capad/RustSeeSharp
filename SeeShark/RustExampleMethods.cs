using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;

namespace SeeShark // Note: actual namespace depends on the project name.
{
    public static class RustExampleMethods
    {
        [DllImport("rusted_sea.dll")]
        public static extern Int32 add_numbers(Int32 arg1, Int32 arg2);

        [DllImport("rusted_sea.dll")]
        public static extern ExampleStruct get_example_struct();
    }

    public class REM
    {
        [Benchmark]
        public Int32 AddNumbers() => RustExampleMethods.add_numbers(10, 5);

        [Benchmark]
        public ExampleStruct GetExampleStruct() => RustExampleMethods.get_example_struct();
    }
}
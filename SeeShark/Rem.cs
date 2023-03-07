using BenchmarkDotNet.Attributes;
using SeeSharkLib;

namespace SeeShark
{
    public class REM
    {
        [Benchmark]
        public Int32 AddNumbers() => RustExampleMethods.add_numbers(10, 5);

        [Benchmark]
        public ExampleStruct GetExampleStruct() => RustExampleMethods.get_example_struct();

        [Benchmark]
        public bool GetBool() => RustExampleMethods.get_opposite_bool(true);
    }
}


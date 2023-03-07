using BenchmarkDotNet.Attributes;
using SeeSharkLib;

namespace SeeShark
{
    public class SEM
    {
        [Benchmark]
        public Int32 AddNumbers() => SharpExampleMethods.add_numbers(10, 5);

        [Benchmark]
        public ExampleStruct GetExampleStruct() => SharpExampleMethods.get_example_struct();

        [Benchmark]
        public bool GetBool() => SharpExampleMethods.get_opposite_bool(true);

        [Benchmark]
        public string GetString() => SharpExampleMethods.get_hello_sea("Hello world");
    }
}
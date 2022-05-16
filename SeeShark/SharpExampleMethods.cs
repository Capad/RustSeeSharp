using BenchmarkDotNet.Attributes;

namespace SeeShark // Note: actual namespace depends on the project name.
{
    public static class SharpExampleMethods
    {
        public static Int32 add_numbers(Int32 arg1, Int32 arg2)
        {
            return arg1 + arg2;
        }

        public static ExampleStruct get_example_struct()
        {
            return new ExampleStruct() { x = 1, y = 2 };
        }
    }

    public class SEM
    {
        [Benchmark]
        public Int32 AddNumbers() => SharpExampleMethods.add_numbers(10, 5);

        [Benchmark]
        public ExampleStruct GetExampleStruct() => SharpExampleMethods.get_example_struct();
    }
}
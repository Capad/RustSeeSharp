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

        public static bool get_opposite_bool(bool v)
        {
            return !v;
        }

        public static string get_hello_sea(string v)
        {
            return v.Replace("world", "sea");
        }
    }

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
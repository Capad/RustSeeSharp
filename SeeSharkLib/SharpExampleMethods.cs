using System;

namespace SeeSharkLib;

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
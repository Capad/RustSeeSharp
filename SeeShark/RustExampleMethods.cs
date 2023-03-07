using SeeSharkLib;
using System.Runtime.InteropServices;

namespace SeeShark
{
    public static class RustExampleMethods
    {
        [DllImport("rusted_sea.dll")]
        public static extern Int32 add_numbers(Int32 arg1, Int32 arg2);

        [DllImport("rusted_sea.dll")]
        public static extern ExampleStruct get_example_struct();

        [DllImport("rusted_sea.dll")]
        public static extern bool get_opposite_bool(bool condition);
    }
}
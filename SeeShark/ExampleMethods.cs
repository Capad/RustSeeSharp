using System.Runtime.InteropServices;


namespace SeeShark // Note: actual namespace depends on the project name.
{
    internal static class ExampleMethods
    {
        [DllImport("rusted_sea.dll")]
        public static extern Int32 add_numbers(Int32 arg1, Int32 arg2);

        [DllImport("rusted_sea.dll")]
        public static extern ExampleStruct get_example_struct();
    }
}
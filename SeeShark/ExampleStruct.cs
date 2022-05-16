using System.Runtime.InteropServices;

namespace SeeShark
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ExampleStruct
    {
        public Int32 x;
        public Int32 y;
    }
}
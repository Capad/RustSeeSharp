using BenchmarkDotNet.Running;
namespace SeeShark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sem = BenchmarkRunner.Run<SEM>();

            var rem = BenchmarkRunner.Run<REM>();
        }
    }
}
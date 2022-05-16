using BenchmarkDotNet.Running;
namespace SeeShark // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summarySharp = BenchmarkRunner.Run<SEM>();

            var summaryRust = BenchmarkRunner.Run<REM>();
        }
    }
}
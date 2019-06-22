using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Benchmark.EmailFromToken
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<TestCaseWrapper>();
        }
    }

    [MemoryDiagnoser]
    [RPlotExporter, RankColumn]
    public class TestCaseWrapper
    {
        // Uncomment the code bellow to use parameters
        //[Params(10, 100)]
        //public static int Number;

        // Uncomment the code bellow to use the Global Setup method
        //[GlobalSetup]
        //public void Setup()
        //{
        //}

        [Benchmark]
        public void TestCase1()
        {
            // your code here
            // don`t forget to rename the function!
        }

        [Benchmark]
        public void TestCase2()
        {
            // your code here
            // don`t fornet to rename the funcion!
        }
    }
}

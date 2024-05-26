using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using HackerRank.Solutions;
using System;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            //BenchmarkRunner.Run<BenchMarkLookUp>();
            //Console.ReadLine();

            new SumOfSeries().Execute();
            Console.ReadKey();
        }
    }

    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class BenchMarkLookUp
    {
        PrintDependencies PrintDependencies = new PrintDependencies();

        [Benchmark]
        public void RunWithoutRemovingCurrentRecord()
        {
            PrintDependencies.ExecuteWithoutRemovingCurrentRecord();
        }

        [Benchmark]
        public void RunWithRemovingCurrentRecord()
        {
            PrintDependencies.ExecuteWithRemovingCurrentRecord();
        }
    }
}

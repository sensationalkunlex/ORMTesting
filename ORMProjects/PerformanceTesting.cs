using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using ORMProject.ORM;


namespace ORMProject
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public  class PerformanceTesting
    {
        [Params(5000, 10000, 20000)]
        public int TotalSize { get; set; } 

        [Benchmark]
        public void EvaluationDapperQuery()
        {
            DapperQuery.SelectQueryImplementation(TotalSize);
        }

        [Benchmark]
        public void EvaluationEFQuery()
        {
            EFQuery.SelectQueryImplementation(TotalSize);
        }
    }
}

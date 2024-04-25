using BenchmarkDotNet.Attributes;
using EFCoreORMTesting.SeedData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreORMTesting
{
    
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class PerformanceTesting
    {
        [Params(1000, 5000, 10000)] 
        public int TotalSize { get; set; }
        [Benchmark]
        [Description("Assess EF Core's BatchMethod When Seeding Data Using the AddRange Method.")]
        public void EvaluateDataSeederWithBatchMethodAndAddRange()
        {
            DataSeederWithBatchMethod.SeedData(TotalSize);
        }
        [Benchmark]
        [Description("Assess EF Core When Seeding Data Using the AddRange Method.")]
        public void EvaluateDataSeederWithAddRange()
        {
            DataSeederWithAddRange.SeedData(TotalSize);
        }
        [Benchmark]
        [Description("Assess EF Core When Seeding Data Using Only the Add Method.")]
        public void EvaluateDataSeederOnlyAddMethod()
        {
            DataSeederOnlyAddMethod.SeedData(TotalSize);
        }
       
    }
}

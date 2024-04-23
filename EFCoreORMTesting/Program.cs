// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using EFCoreORMTesting;
using EFCoreORMTesting.SeedData;
using ORMTesting.Data;
using System.Diagnostics;
//int total = 200000;
//Stopwatch stopwatch = new Stopwatch();


//Console.WriteLine("Class {0}", nameof(SeedDataBySingleAdd));
////stopwatch.Reset();
//stopwatch.Start();
//int recordsBySingleAdd = SeedDataBySingleAdd.SeedData(total);
//stopwatch.Stop();
//Console.WriteLine(
//    "Method {0} Time elapsed: {1} Number of records saved {2} ",
//    nameof(SeedDataBySingleAdd),
//    stopwatch.Elapsed, recordsBySingleAdd);



//Console.WriteLine("Class {0}", nameof(SeedDataByRange));

//stopwatch.Start();
//int recordByRange = SeedDataByRange.SeedData(total);
//stopwatch.Stop();
//Console.WriteLine(
//    "Method {0} Time elapsed: {1} Number of records saved {2} ",
//    nameof(SeedDataByRange),
//    stopwatch.Elapsed, recordByRange);






//Console.WriteLine("Class {0}", nameof(SeedDataByBatchRange));
////stopwatch.Reset();
//stopwatch.Start();
//int records = SeedDataByBatchRange.SeedData(total);
//stopwatch.Stop();
//Console.WriteLine(
//    "Class {0} Time elapsed: {1} Number of records saved {2} ",
//    nameof(SeedDataByBatchRange),
//    stopwatch.Elapsed, records);


BenchmarkRunner.Run<PerformanceTesting>();
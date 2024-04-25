// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using ORMProject;
using ORMProject.ORM;

Console.WriteLine("Hello, World!");
//BenchmarkRunner.Run<PerformanceTesting>();
//var test = new PerformanceTesting();
//test.EvaluationEFQuery();
//test.EvaluationDapperQuery();
DapperQuery.SelectQueryImplementation();
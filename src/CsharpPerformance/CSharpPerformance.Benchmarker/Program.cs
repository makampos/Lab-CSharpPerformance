using BenchmarkDotNet.Running;

// var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
// var summary = BenchmarkRunner.Run(typeof(CSharpPerformance.Benchmarker.StringComparison));
// var summary = BenchmarkRunner.Run(typeof(CSharpPerformance.Benchmarker.Loops));
// var summary = BenchmarkRunner.Run(typeof(CSharpPerformance.Benchmarker.ClassVsStruct));
// var summary = BenchmarkRunner.Run(typeof(CSharpPerformance.Benchmarker.Assigment));
var summary = BenchmarkRunner.Run(typeof(CSharpPerformance.Benchmarker.DateStuff));


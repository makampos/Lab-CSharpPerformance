﻿using BenchmarkDotNet.Running;

// var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
var summary = BenchmarkRunner.Run(typeof(CSharpPerformance.Benchmarker.StringComparison));
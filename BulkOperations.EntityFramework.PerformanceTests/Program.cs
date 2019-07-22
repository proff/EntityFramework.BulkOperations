﻿using BenchmarkDotNet.Running;

namespace BulkOperations.EntityFramework.PerformanceTests
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            var t = new Test();
            t.Count = 1;
            t.Setup();
            t.BatchSaveChanges();
#else
            var summary = BenchmarkRunner.Run<Test>();
#endif
        }
    }
}
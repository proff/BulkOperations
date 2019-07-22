using System;
using System.Linq;
using System.Transactions;
using BenchmarkDotNet.Attributes;
using EntityFramework.BulkOperations.Tests.Models;

namespace EntityFramework.BulkOperations.PerformanceTests
{
    [RyuJitX64Job]
    [MemoryDiagnoser]
    public class Test
    {
        [Params(1, 10, 100, 1000, 10000)] public int Count;
        private AdventureWorksContext _db;
        private TransactionScope _tran;

        [IterationSetup]
        public void Setup()
        {
            _db = new AdventureWorksContext();
            foreach (var header in _db.SalesOrderHeaders.Take(Count))
            {
                header.Comment = Guid.NewGuid().ToString();
            }

            _tran = new TransactionScope(TransactionScopeOption.Required,
                new TransactionOptions() {IsolationLevel = IsolationLevel.ReadCommitted});
        }

        [Benchmark]
        public void SaveChanges()
        {
            _db.SaveChanges();
            _db.Dispose();
            _tran.Complete();
            _tran.Dispose();
        }

        [Benchmark]
        public void BatchSaveChanges()
        {
            _db.BatchSaveChanges();
            _db.Dispose();
            _tran.Complete();
            _tran.Dispose();
        }
    }
}
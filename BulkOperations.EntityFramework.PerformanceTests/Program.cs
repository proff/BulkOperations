using System;
using System.IO;
using BenchmarkDotNet.Running;
using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Containers;

namespace BulkOperations.EntityFramework.PerformanceTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var consumer = Consume.RedirectStdoutAndStderrToStream(new MemoryStream(), new MemoryStream());
            var a = new TestcontainersBuilder<TestcontainersContainer>().WithName(Guid.NewGuid().ToString("D"))
                .WithImage("chriseaton/adventureworks").WithEnvironment("ACCEPT_EULA", "Y")
                .WithEnvironment("SA_PASSWORD", "Yf7(nk,&vT`|Zkiw").WithPortBinding(15826, 1433).WithOutputConsumer(consumer).WithWaitStrategy(Wait.ForUnixContainer().UntilMessageIsLogged(consumer.Stdout, "Server is ready.")).Build();
            a.StartAsync().Wait();
#if DEBUG
            var t = new Test();
            t.Count = 1000;
            t.Setup();
            t.BatchSaveChanges();
#else
            var summary = BenchmarkRunner.Run<Test>();
#endif
        }
    }
}
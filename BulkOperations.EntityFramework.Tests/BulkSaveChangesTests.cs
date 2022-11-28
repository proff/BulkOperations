using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BulkOperations.EntityFramework.Tests.Model;
using Docker.DotNet;
using Docker.DotNet.Models;
using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Configurations;
using DotNet.Testcontainers.Containers;
using Microsoft.Extensions.Logging;
using NUnit.Framework;

namespace BulkOperations.EntityFramework.Tests
{
    public class BulkSaveChangesTests
    {
        [OneTimeSetUp]
        public async Task Setup()
        {
            var consumer = Consume.RedirectStdoutAndStderrToStream(new MemoryStream(), new MemoryStream());
            var a = new TestcontainersBuilder<TestcontainersContainer>().WithName(Guid.NewGuid().ToString("D"))
                .WithImage("chriseaton/adventureworks").WithEnvironment("ACCEPT_EULA", "Y")
                .WithEnvironment("SA_PASSWORD", "Yf7(nk,&vT`|Zkiw").WithPortBinding(15826, 1433).WithOutputConsumer(consumer).WithWaitStrategy(Wait.ForUnixContainer().UntilMessageIsLogged(consumer.Stdout, "Server is ready.")).Build();
            await a.StartAsync();
        }

        [Test]
        public async Task SimpleUpdateAsync()
        {
            const int count = 50;
            var newValues = new List<string>();
            using (var context = new AdventureWorksContext())
            {
                var list = context.Sales_SalesOrderHeaders.OrderBy(a => a.SalesOrderId).Take(count);
                foreach (var entity in list)
                {
                    var value = Guid.NewGuid().ToString();
                    entity.Comment = value;
                    newValues.Add(value);
                }

                await context.BulkSaveChangesAsync();
            }

            using (var context = new AdventureWorksContext())
            {
                var list = context.Sales_SalesOrderHeaders.OrderBy(a => a.SalesOrderId).Take(count).ToList();
                for (var i = 0; i < list.Count; i++)
                {
                    Assert.That(list[i].Comment, Is.EqualTo(newValues[i]));
                }
            }
        }

        [Test]
        public async Task SimpleUpdateExternalContextAsync()
        {
            const int count = 50;
            var newValues = new List<string>();
            using (var context = new ExternalAdventureWorksContext())
            {
                var list = context.Sales_SalesOrderHeaders.OrderBy(a=>a.SalesOrderId).Take(count);
                foreach (var entity in list)
                {
                    var value = Guid.NewGuid().ToString();
                    entity.Comment = value;
                    newValues.Add(value);
                }

                await context.BulkSaveChangesAsync();
            }

            using (var context = new AdventureWorksContext())
            {
                var list = context.Sales_SalesOrderHeaders.OrderBy(a => a.SalesOrderId).Take(count).ToList();
                for (var i = 0; i < list.Count; i++)
                {
                    Assert.That(list[i].Comment, Is.EqualTo(newValues[i]));
                }
            }
        }

        [Test]
        public async Task SimpleUpsertAsync()
        {
            const int count = 50;
            var newValues = new List<string>();
            using (var context = new AdventureWorksContext())
            {
                var list = context.Sales_Currencies.OrderBy(a => a.CurrencyCode).Take(count);
                foreach (var entity in list)
                {
                    var value = Guid.NewGuid().ToString();
                    entity.Name = value;
                    newValues.Add(value);
                }

                await context.BulkUpsertAsync(new Sales_Currency[]{new Sales_Currency(){CurrencyCode = "ZZZ", Name = "ZZZ"}});
            }

            using (var context = new AdventureWorksContext())
            {
                var list = context.Sales_Currencies.OrderBy(a => a.CurrencyCode).Take(count).ToList();
                for (var i = 0; i < list.Count; i++)
                {
                    Assert.That(list[i].Name, Is.EqualTo(newValues[i]));
                }
            }
        }

        class Test : TestcontainersContainer
        {
            public Test(ITestcontainersConfiguration configuration, ILogger logger) : base(configuration, logger)
            {
            }
        }
    }
}
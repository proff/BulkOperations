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
            var mssqlConfiguration = new MsSqlTestcontainerConfiguration();
            mssqlConfiguration.Password = "Yf7(nk,&vT`|Zkiw";
            mssqlConfiguration.Database = "test";
            mssqlConfiguration.Port = 15826;

            var mssqlContainer = new TestcontainersBuilder<MsSqlTestcontainer>()
                .WithDatabase(mssqlConfiguration)
                .Build();
            
            /*var consumer = Consume.RedirectStdoutAndStderrToStream(new MemoryStream(), new MemoryStream());
            var a = new TestcontainersBuilder<TestcontainersContainer>().WithName(Guid.NewGuid().ToString("D"))
                .WithImage("chriseaton/adventureworks").WithEnvironment("ACCEPT_EULA", "Y")
                .WithEnvironment("SA_PASSWORD", "Yf7(nk,&vT`|Zkiw").WithPortBinding(15826, 1433).WithOutputConsumer(consumer).WithWaitStrategy(Wait.ForUnixContainer().UntilMessageIsLogged(consumer.Stdout, "Server is ready.")).Build();*/
            await mssqlContainer.StartAsync();
            var db = new TestDbContext();
            db.Database.CreateIfNotExists();
            for (int i = 0; i < 1000; i++)
            {
                db.TestEntityIdentityInts.Add(new TestEntityIdentityInt() { Name = Guid.NewGuid().ToString() });
            }

            await db.SaveChangesAsync();
        }

        [Test]
        public async Task SimpleUpdateAsync()
        {
            const int count = 50;
            var newValues = new List<string>();
            using (var context = new TestDbContext())
            {
                var list = context.TestEntityIdentityInts.OrderBy(a => a.Id).Take(count);
                foreach (var entity in list)
                {
                    var value = Guid.NewGuid().ToString();
                    entity.Name = value;
                    newValues.Add(value);
                }

                await context.BulkSaveChangesAsync();
            }

            using (var context = new TestDbContext())
            {
                var list = context.TestEntityIdentityInts.OrderBy(a => a.Id).Take(count).ToList();
                for (var i = 0; i < list.Count; i++)
                {
                    Assert.That(list[i].Name, Is.EqualTo(newValues[i]));
                }
            }
        }

        [Test]
        public async Task SimpleUpdateExternalContextAsync()
        {
            const int count = 50;
            var newValues = new List<string>();
            using (var context = new TestExternalDbContext())
            {
                var list = context.TestEntityIdentityInts.OrderBy(a=>a.Id).Take(count);
                foreach (var entity in list)
                {
                    var value = Guid.NewGuid().ToString();
                    entity.Name = value;
                    newValues.Add(value);
                }

                await context.BulkSaveChangesAsync();
            }

            using (var context = new TestDbContext())
            {
                var list = context.TestEntityIdentityInts.OrderBy(a => a.Id).Take(count).ToList();
                for (var i = 0; i < list.Count; i++)
                {
                    Assert.That(list[i].Name, Is.EqualTo(newValues[i]));
                }
            }
        }

        [Test]
        public async Task SimpleUpsertAsync()
        {
            const int count = 50;
            var newValues = new List<string>();
            using (var context = new TestDbContext())
            {
                var list = context.TestEntityIdentityInts.OrderBy(a => a.Id).Take(count);
                foreach (var entity in list)
                {
                    var value = Guid.NewGuid().ToString();
                    entity.Name = value;
                    newValues.Add(value);
                }

                await context.BulkUpsertAsync(new TestEntityIdentityInt[]{new TestEntityIdentityInt(){Id = 1000000, Name = "ZZZ"}});
            }

            using (var context = new TestDbContext())
            {
                var list = context.TestEntityIdentityInts.OrderBy(a => a.Id).Take(count).ToList();
                for (var i = 0; i < list.Count; i++)
                {
                    Assert.That(list[i].Name, Is.EqualTo(newValues[i]));
                }
            }
        }
    }
}
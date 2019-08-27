using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Task1.Interfaces;
using Task1.Model;
using Task1Tests1.TestModel;

namespace Task1.Tests
{
    [TestClass()]
    public class CalculationTests
    {
        IDataSource _source;

        /// <summary>
        ///     Mock DataSource
        /// </summary>
        [TestInitialize]
        public void TestInit()
        {
            #region IOC initialization

            var builder = new ContainerBuilder();
            builder.RegisterType<MockDataSource>().As<IDataSource>();
            var container = builder.Build();
            _source = container.Resolve<IDataSource>();

            #endregion IOC initialization
        }

        [TestMethod()]
        public void GetProductWithPosition_JoinCountResult()
        {
            Calculation c = new Calculation(_source);

            var positionPrice = c.GetProductWithPosition();

            var noOfJoinedRecords = positionPrice.ToList().Count;

            Assert.IsTrue(noOfJoinedRecords == 1000);
        }

        [TestMethod()]
        public void GetProductWithPosition_ExecutionTimeLessThan5ms()
        {
            var maxExecutionTime = 5;
            Calculation c = new Calculation(_source);

            var watch = System.Diagnostics.Stopwatch.StartNew();

            c.GetProductWithPosition();

            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;

            Assert.IsTrue(elapsedMs < maxExecutionTime);
        }
    }
}
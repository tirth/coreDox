using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using coreDox.Core.Services;
using System.Linq;

namespace coreDox.Core.Tests
{
    [TestClass]
    public class ExporterSericeTests
    {
        [TestMethod]
        public void ShouldGetRegisteredExporterSuccessfully()
        {
            //Arrange
            var exporterService = new ExporterService();

            //Act
            var exporter = exporterService.GetRegisteredExporters();

            //Assert
            Assert.IsTrue(exporter.Count == 1);
            Assert.AreEqual("Html", exporter.First().ExporterName);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using coreDox.Core.Services;
using System.Linq;

namespace coreDox.Core.Tests
{
    [TestClass]
    public class ExporterServiceTests
    {
        [TestMethod]
        public void ShouldGetRegisteredExporterSuccessfully()
        {
            //Arrange
            var exporterService = ServiceLocator.GetService<ExporterService>();

            //Act
            var exporter = exporterService.RegisteredExporter;

            //Assert
            Assert.IsTrue(exporter.Count == 1);
            Assert.AreEqual("Html", exporter.First().ExporterName);
        }
    }
}

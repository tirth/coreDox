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
            var exporter = exporterService.RegisteredExporterTypes;

            //Assert
            Assert.IsTrue(exporter.Count == 1);
            Assert.AreEqual("HtmlExporter", exporter.First().Name);
        }
    }
}

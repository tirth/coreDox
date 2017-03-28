using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using coreDox.Core.Services;
using System.Linq;
using coreDox.Core.Model.Documentation;

namespace coreDox.Core.Tests
{
    [TestClass]
    public class ConfigServiceTests
    {
        [TestMethod]
        public void ShouldGetDoxConfigSuccessfully()
        {
            //Arrange
            var configService = ServiceLocator.GetService<ConfigService>();

            //Act
            var doxConfig = configService.GetConfig<DoxProject>();

            //Assert
            Assert.IsNotNull(doxConfig);
        }
    }
}

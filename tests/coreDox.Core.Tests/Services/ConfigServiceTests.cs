using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using coreDox.Core.Services;
using System.Linq;

namespace coreDox.Core.Tests
{
    [TestClass]
    public class ConfigServiceTests
    {
        [TestMethod]
        public void ShouldGetCLIConfigSuccessfully()
        {
            //Arrange
            var configService = ServiceLocator.GetService<ConfigService>();

            //Act
            configService.RegisterConfig(new CLIConfig());
            var cliConfig = configService.GetConfig<CLI>();

            //Assert
            Assert.IsNotNull(cliConfig);
        }
    }
}

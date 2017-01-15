using Microsoft.VisualStudio.TestTools.UnitTesting;

using coreDox;

namespace coreDox.Tests
{
    [TestClass]
    public class CommandLineArgsTests
    {
        [DataTestMethod]
        [DataRow("new")]
        [DataRow("build")]
        [DataRow("watch")]
        [DataRow("notavail")]
        public void ShouldParseVerbSuccessfully(string verb)
        {
            // Arrange
            CommandLineArgs commandLineArgs;
            var args = new [] { verb };

            // Act
            CommandLineArgs.TryParse(args, out commandLineArgs);

            // Assert
            Assert.IsNotNull(commandLineArgs.VerbArgument);
            Assert.AreEqual(verb, commandLineArgs.VerbArgument.Verb);
        }

        [DataTestMethod]
        [DataRow("-h")]
        [DataRow("--help")]
        public void ShouldParseHelpSuccessfully(string arg)
        {
            // Arrange
            CommandLineArgs commandLineArgs;
            var args = new [] { arg };

            // Act
            CommandLineArgs.TryParse(args, out commandLineArgs);

            // Assert
            Assert.IsNotNull(commandLineArgs.HelpArgument);
        }

        [DataTestMethod]
        [DataRow("-v")]
        [DataRow("--version")]
        public void ShouldParseVersionSuccessfully(string arg)
        {
            // Arrange
            CommandLineArgs commandLineArgs;
            var args = new [] { arg };

            // Act
            CommandLineArgs.TryParse(args, out commandLineArgs);

            // Assert
            Assert.IsNotNull(commandLineArgs.VersionArgument);
        }

        [DataTestMethod]
        [DataRow("-a", "verb")]
        [DataRow("--notavail", "-t")]
        [DataRow("-n", "verb")]
        public void ShouldParseNotSuccessullfy(string arg1, string arg2)
        {
            // Arrange
            CommandLineArgs commandLineArgs;
            var args = new [] { arg1, arg2 };

            // Act
            var success = CommandLineArgs.TryParse(args, out commandLineArgs);

            // Assert
            Assert.IsFalse(success);
        }
    }
}

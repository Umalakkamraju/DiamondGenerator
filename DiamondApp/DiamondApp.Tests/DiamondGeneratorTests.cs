using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace DiamondApp.Tests
{
    [TestClass]
    public class DiamondGeneratorTests
    {


        [TestMethod]
        public void GenerateDiamond_ForA_ReturnsA()
        {
            // Arrange
            var expected = "A\n";

            // Act
            var result = DiamondGenerator.Generate('A');

            // Debug output
            Console.WriteLine($"Expected: '{expected.Trim()}'");
            Console.WriteLine($"Actual: '{result.Trim()}'");

            // Assert
            Assert.AreEqual(expected.Trim(), result.Trim());
        }



        // Test case for generating diamond with 'B'
        [TestMethod]
        public void GenerateDiamond_ForB_ReturnsDiamond()
        {
            // Arrange: expected output for 'B'
            var expected = new StringBuilder()
                .AppendLine(" A ")
                .AppendLine("B B")
                .AppendLine(" A ")
                .ToString();

            // Act: generate diamond for 'B'
            var result = DiamondGenerator.Generate('B');

            // Assert: check if the generated diamond matches the expected output
            Assert.AreEqual(expected, result);
        }

        // Test case for generating diamond with 'C'
        [TestMethod]
        public void GenerateDiamond_ForC_ReturnsDiamond()
        {
            // Arrange: expected output for 'C'
            var expected = new StringBuilder()
                .AppendLine("  A  ")
                .AppendLine(" B B ")
                .AppendLine("C   C")
                .AppendLine(" B B ")
                .AppendLine("  A  ")
                .ToString();

            // Act: generate diamond for 'C'
            var result = DiamondGenerator.Generate('C');

            // Assert: check if the generated diamond matches the expected output
            Assert.AreEqual(expected, result);
        }
    }
}

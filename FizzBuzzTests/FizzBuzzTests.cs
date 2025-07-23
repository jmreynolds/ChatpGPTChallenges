namespace FizzBuzzTests
{
    [TestClass]
    public sealed class FizzBuzzTests
    {
        [TestMethod]
        public void ShouldReturnTrue()
        {
            // Arrange
            var expected = true;
            // Act
            var actual = true;
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ShouldReturnFalse()
        {
            // Arrange
            var expected = false;
            // Act
            var actual = false;
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

using Xunit;

namespace Aurochses.Data.Extensions.MsSql.Tests
{
    public class FunctionsTests
    {
        [Fact]
        public void NewSequentialId_Value_Equals()
        {
            // Arrange & Act & Assert
            Assert.Equal("newsequentialid()", Functions.NewSequentialId);
        }

        [Fact]
        public void GetUtcDate_Value_Equals()
        {
            // Arrange & Act & Assert
            Assert.Equal("getutcdate()", Functions.GetUtcDate);
        }
    }
}
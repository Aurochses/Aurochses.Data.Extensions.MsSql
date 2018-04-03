using Xunit;

namespace Aurochses.Data.Extensions.MsSql.Tests
{
    public class ColumnTypesTests
    {
        [Fact]
        public void NVarChar_Value_Equals()
        {
            // Arrange & Act & Assert
            Assert.Equal("nvarchar", ColumnTypes.NVarChar);
        }

        [Fact]
        public void NVarCharMax_Value_Equals()
        {
            // Arrange & Act & Assert
            Assert.Equal("nvarchar(max)", ColumnTypes.NVarCharMax);
        }

        [Fact]
        public void MoneyAsDecimal_Value_Equals()
        {
            // Arrange & Act & Assert
            Assert.Equal("decimal(19,6)", ColumnTypes.MoneyAsDecimal);
        }

        [Fact]
        public void DateTime_Value_Equals()
        {
            // Arrange & Act & Assert
            Assert.Equal("datetime2", ColumnTypes.DateTime);
        }

        [Fact]
        public void Date_Value_Equals()
        {
            // Arrange & Act & Assert
            Assert.Equal("date", ColumnTypes.Date);
        }

        [Fact]
        public void GetNVarCharWithSpecifiedLength_Value_Equals()
        {
            // Arrange & Act & Assert
            Assert.Equal("nvarchar(255)", ColumnTypes.GetNVarCharWithSpecifiedLength());
            Assert.Equal("nvarchar(100)", ColumnTypes.GetNVarCharWithSpecifiedLength(100));
        }
    }
}
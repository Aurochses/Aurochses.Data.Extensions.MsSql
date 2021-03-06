﻿using Xunit;

namespace Aurochses.Data.Extensions.MsSql.Tests
{
    public class ColumnLengthsTests
    {
        [Fact]
        public void DefaultNVarChar_Value_Equals()
        {
            // Arrange & Act & Assert
            Assert.Equal(255, ColumnLengths.DefaultNVarChar);
        }

        [Fact]
        public void UniqueName_Value_Equals()
        {
            // Arrange & Act & Assert
            Assert.Equal(50, ColumnLengths.UniqueName);
        }
    }
}
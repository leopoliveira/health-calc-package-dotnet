using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HealthCalcPack.O3.Implementations;
using HealthCalcPack.O3.Interfaces;

namespace HealthCalcPack.Tests.IMCTests
{
    public class IMCIsValidTest
    {
        [Theory]
        [InlineData(1.8, 7.6)]
        [InlineData(2, 290)]
        public void IMCIsValid_ValidValues_ValidResult(double height, double weight)
        {
            // Arrange
            IIMC imc = new IMC();

            // Methods
            bool result = imc.IsValidData(height, weight);

            // Test
            Assert.True(result);
        }

        [Theory]
        [InlineData(1.8, 301)]
        [InlineData(1.8, 0)]
        [InlineData(1.8, -1)]
        [InlineData(3.01, 108)]
        [InlineData(0, 108)]
        [InlineData(-1, 108)]
        public void IMCIsValid_InvalidValues_InvalidResult(double height, double weight)
        {
            // Arrange
            IIMC imc = new IMC();

            // Methods
            bool result = imc.IsValidData(height, weight);

            // Test
            Assert.False(result);
        }
    }
}

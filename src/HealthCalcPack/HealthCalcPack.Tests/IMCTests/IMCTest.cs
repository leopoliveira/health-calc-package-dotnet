using HealthCalcPack.O3.Implementations;
using HealthCalcPack.O3.Interfaces;

namespace HealthCalcPack.Tests.IMCTests
{
    public class IMCTest
    {
        [Fact]
        public void IMCCalc_ValidValues_ValidTest()
        {
            // Arrange
            IIMC imc = new IMC();
            double Height = 1.81;
            double Weight = 77;
            double ExpectedResult = 23.5;

            // Methods
            double result = imc.CalcIMC(Height, Weight);

            // Test
            Assert.Equal(ExpectedResult, result);
        }

        [Fact]
        public void IMCCalc_ValidValues_InvalidTest()
        {
            // Arrange
            IIMC imc = new IMC();
            double Height = 1.81;
            double Weight = 77;
            double ExpectedResult = 50.2;

            // Methods
            double result = imc.CalcIMC(Height, Weight);

            // Test
            Assert.NotEqual(ExpectedResult, result);
        }
    }
}
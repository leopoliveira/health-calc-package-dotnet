using HealthCalcPack.O3.Implementations;
using HealthCalcPack.O3.Interfaces;

namespace HealthCalcPack.Tests.IMCCalcTests
{
    public class IMCCalcTest
    {
        [Fact]
        public void IMCCalc_ValidValues_ValidTest()
        {
            // Arrange
            IIMC imc = new IMC();
            double height = 1.81;
            double weight = 77;
            double expectedResult = 23.5;

            // Methods
            double result = imc.CalcIMC(height, weight);

            // Test
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void IMCCalc_ValidValues_InvalidTest()
        {
            // Arrange
            IIMC imc = new IMC();
            double Height = 1.81;
            double Weight = 77;
            // Real Value = 23.5
            double ExpectedResult = 50.2;

            // Methods
            double result = imc.CalcIMC(Height, Weight);

            // Test
            Assert.NotEqual(ExpectedResult, result);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HealthCalcPack.O3.Implementations;
using HealthCalcPack.O3.Interfaces;

namespace HealthCalcPack.Tests.IMCTests
{
    public class IMCCategoryTest
    {
        [Fact]
        public void IMCCategory_ValidValues_ValidTesT()
        {
            // Arrange
            IIMC imc = new IMC();
            double imcValue = 50.2;
            string expectedResult = "Grave";

            // Methods
            string result = imc.GetIMCCategory(imcValue);

            // Test
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void IMCCategoru_ValidValues_InvalidTest()
        {
            // Arrange
            IIMC imc = new IMC();
            double imcValue = 20.2;
            string expectedResult = "Grave";

            // Methods
            string result = imc.GetIMCCategory(imcValue);

            // Test
            Assert.NotEqual(expectedResult, result);
        }
    }
}

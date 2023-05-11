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
        public void IMCCategory_Magreza_ValidTest()
        {
            // Arrange
            IIMC imc = new IMC();
            double imcValue = 17;
            string expectedResult = "Magreza";

            // Methods
            string result = imc.GetIMCCategory(imcValue);

            // Test
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void IMCCategory_Normal_ValidTest()
        {
            // Arrange
            IIMC imc = new IMC();
            double imcValue = 20;
            string expectedResult = "Normal";

            // Methods
            string result = imc.GetIMCCategory(imcValue);

            // Test
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void IMCCategory_Sobrepeso_ValidTest()
        {
            // Arrange
            IIMC imc = new IMC();
            double imcValue = 25;
            string expectedResult = "Sobrepeso";

            // Methods
            string result = imc.GetIMCCategory(imcValue);

            // Test
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void IMCCategory_Obesidade_ValidTest()
        {
            // Arrange
            IIMC imc = new IMC();
            double imcValue = 35;
            string expectedResult = "Obesidade";

            // Methods
            string result = imc.GetIMCCategory(imcValue);

            // Test
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void IMCCategory_Grave_ValidTest()
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
        public void IMCCategory_Invalid_ValidTest()
        {
            // Arrange
            IIMC imc = new IMC();
            double imcValue = 0;
            string expectedResult = "Invalido";

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

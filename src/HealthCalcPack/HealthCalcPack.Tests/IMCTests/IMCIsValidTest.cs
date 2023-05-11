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
        [Fact]
        public void IMCIsValid_ValidValues_ValidResult()
        {
            // Arrange
            IIMC imc = new IMC();
            double heigth = 1.8;
            double weight = 76;

            // Methods
            bool result = imc.IsValidData(heigth, weight);

            // Test
            Assert.True(result);
        }

        [Fact]
        public void IMCIsValid_InvalidWeight1_InvalidResult()
        {
            // Arrange
            IIMC imc = new IMC();
            double heigth = 1.8;
            double weight = 301;

            // Methods
            bool result = imc.IsValidData(heigth, weight);

            // Test
            Assert.False(result);
        }

        [Fact]
        public void IMCIsValid_InvalidWeight2_InvalidResult()
        {
            // Arrange
            IIMC imc = new IMC();
            double heigth = 1.8;
            double weight = 0;

            // Methods
            bool result = imc.IsValidData(heigth, weight);

            // Test
            Assert.False(result);
        }

        [Fact]
        public void IMCIsValid_InvalidWeight3_InvalidResult()
        {
            // Arrange
            IIMC imc = new IMC();
            double heigth = 1.8;
            double weight = -1;

            // Methods
            bool result = imc.IsValidData(heigth, weight);

            // Test
            Assert.False(result);
        }

        [Fact]
        public void IMCIsValid_InvalidHeight1_InvalidResult()
        {
            // Arrange
            IIMC imc = new IMC();
            double heigth = 3.01;
            double weight = 108;

            // Methods
            bool result = imc.IsValidData(heigth, weight);

            // Test
            Assert.False(result);
        }

        [Fact]
        public void IMCIsValid_InvalidHeight2_InvalidResult()
        {
            // Arrange
            IIMC imc = new IMC();
            double heigth = 0;
            double weight = 108;

            // Methods
            bool result = imc.IsValidData(heigth, weight);

            // Test
            Assert.False(result);
        }

        [Fact]
        public void IMCIsValid_InvalidHeight3_InvalidResult()
        {
            // Arrange
            IIMC imc = new IMC();
            double heigth = -1;
            double weight = 108;

            // Methods
            bool result = imc.IsValidData(heigth, weight);

            // Test
            Assert.False(result);
        }
    }
}

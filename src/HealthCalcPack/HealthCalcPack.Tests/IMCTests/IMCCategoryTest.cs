using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HealthCalcPack.O3.Helpers;
using HealthCalcPack.O3.Implementations;
using HealthCalcPack.O3.Interfaces;

namespace HealthCalcPack.Tests.IMCTests
{
    public class IMCCategoryTest
    {
        [Theory]
        [InlineData(17, IMCConstants.MAGREZA)]
        [InlineData(20, IMCConstants.NORMAL)]
        [InlineData(25, IMCConstants.SOBREPESO)]
        [InlineData(30, IMCConstants.OBESIDADE)]
        [InlineData(40, IMCConstants.GRAVE)]
        [InlineData(-1, IMCConstants.VALOR_PADRAO)]
        public void IMCCategory_Magreza_ValidTest(double imcValue, string imcCategory)
        {
            // Arrange
            IIMC imc = new IMC();

            // Methods
            string result = imc.GetIMCCategory(imcValue);

            // Test
            Assert.Equal(imcCategory, result);
        }
    }
}

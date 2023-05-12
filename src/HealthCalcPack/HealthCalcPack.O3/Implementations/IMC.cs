using HealthCalcPack.O3.Helpers;
using HealthCalcPack.O3.Interfaces;

namespace HealthCalcPack.O3.Implementations
{
    /// <summary>
    /// Interface to work with Height and Weight values.
    /// </summary>
    /// <seealso cref="HealthCalcPack.O3.Interfaces.IIMC" />
    public class IMC : IIMC
    {
        /// <summary>
        /// Calculates the imc.
        /// </summary>
        /// <param name="Height">The height.</param>
        /// <param name="Weight">The weight.</param>
        /// <returns>
        /// IMC calculated.
        /// </returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public double CalcIMC(double Height, double Weight)
        {
            double imc = Weight / (Height * Height);

            return Math.Round(imc, IMCConstants.ROUND_DIGITS);
        }

        /// <summary>
        /// Gets the imc category.
        /// </summary>
        /// <param name="Imc">The imc.</param>
        /// <returns>
        /// Return the IMC actual category.
        /// </returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public string GetIMCCategory(double Imc)
        {

            return Imc switch
            {
                > 0 and < IMCConstants.MAGREZA_FAIXA1 => IMCConstants.MAGREZA,
                > IMCConstants.NORMAL_FAIXA1 and < IMCConstants.NORMAL_FAIXA2 => IMCConstants.NORMAL,
                > IMCConstants.SOBREPESO_FAIXA1 and < IMCConstants.SOBREPESO_FAIXA2 => IMCConstants.SOBREPESO,
                > IMCConstants.OBESIDADE_FAIXA1 and < IMCConstants.OBESIDADE_FAIXA2 => IMCConstants.OBESIDADE,
                > IMCConstants.GRAVE_FAIXA1 => IMCConstants.GRAVE,
                _ => IMCConstants.VALOR_PADRAO
            };
        }

        /// <summary>
        /// Determines whether the specified height and weight are valid.
        /// </summary>
        /// <param name="Height">The height.</param>
        /// <param name="Weight">The weight.</param>
        /// <returns>
        /// Don't know.
        /// </returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool IsValidData(double Height, double Weight)
        {
            return Height < IMCConstants.HEIGHT_HIGH_LIMIT
                   && Height > IMCConstants.HEIGHT_LOWER_LIMIT
                   && Weight < IMCConstants.WEIGHT_HIGH_LIMIT
                   && Weight > IMCConstants.WEIGHT_LOWER_LIMIT;
        }
    }
}

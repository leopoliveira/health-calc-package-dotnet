using HealthCalcPack.O3.Entities;
using HealthCalcPack.O3.Entities.Enums;
using HealthCalcPack.O3.Helpers;
using HealthCalcPack.O3.Interfaces;

namespace HealthCalcPack.O3.Implementations
{
    /// <summary>
    /// MacroNutrientes concret class.
    /// </summary>
    /// <seealso cref="HealthCalcPack.O3.Interfaces.IMacroNutrientes" />
    public class MacroNutrientes : IMacroNutrientes
    {
        /// <summary>
        /// Gets the macro nutrientes.
        /// </summary>
        /// <param name="weight">The weight.</param>
        /// <param name="objective">The objective.</param>
        /// <returns></returns>
        public MacroNutrientesObj GetMacroNutrientes(double weight, EnumWeightObjective objective)
        {
            MacroNutrientesObj macronutrientes = objective switch
            {
                EnumWeightObjective.Gain => new MacroNutrientesObj
                {
                    Proteins = Math.Round((weight * 2), IMCConstants.ROUND_DIGITS),
                    Carbohydrates = Math.Round((weight * 4), IMCConstants.ROUND_DIGITS),
                    Fats = Math.Round((weight * 1), IMCConstants.ROUND_DIGITS)
                },
                EnumWeightObjective.Maintain => new MacroNutrientesObj
                {
                    Proteins = Math.Round((weight * 4), IMCConstants.ROUND_DIGITS),
                    Carbohydrates = Math.Round((weight * 4), IMCConstants.ROUND_DIGITS),
                    Fats = Math.Round((weight * 2), IMCConstants.ROUND_DIGITS)
                },
                EnumWeightObjective.Lose => new MacroNutrientesObj
                {
                    Proteins = Math.Round((weight * 4), IMCConstants.ROUND_DIGITS),
                    Carbohydrates = Math.Round((weight * 3), IMCConstants.ROUND_DIGITS),
                    Fats = Math.Round((weight * 3), IMCConstants.ROUND_DIGITS)
                },
                _ => throw new NotImplementedException()
            };

            return macronutrientes;
        }
    }
}

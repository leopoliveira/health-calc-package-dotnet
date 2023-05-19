using HealthCalcPack.O3.Entities;
using HealthCalcPack.O3.Entities.Enums;

namespace HealthCalcPack.O3.Interfaces
{
    public interface IMacroNutrientes
    {
        public MacroNutrientesObj GetMacroNutrientes(double weight, EnumWeightObjective objective);
    }
}

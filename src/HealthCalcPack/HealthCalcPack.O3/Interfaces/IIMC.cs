namespace HealthCalcPack.O3.Interfaces
{
    /// <summary>
    /// Interface to work with Height and Weight values.
    /// </summary>
    public interface IIMC
    {
        /// <summary>
        /// Calculates the imc.
        /// </summary>
        /// <param name="Height">The height.</param>
        /// <param name="Weight">The weight.</param>
        /// <returns>IMC calculated.</returns>
        double CalcIMC(double Height,  double Weight);

        /// <summary>
        /// Determines whether the specified height and weight are valid.
        /// </summary>
        /// <param name="Height">The height.</param>
        /// <param name="Weight">The weight.</param>
        /// <returns>Don't know.</returns>
        double IsValidData(double Height, double Weight);

        /// <summary>
        /// Gets the imc category.
        /// </summary>
        /// <param name="Imc">The imc.</param>
        /// <returns>Return the IMC actual category.</returns>
        string GetIMCCategory(double Imc);
    }
}
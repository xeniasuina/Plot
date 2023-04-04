namespace Plot.Enums
{
    public enum CalculationType
    {
        /// <summary>
        /// Метод левых прямоугольников
        /// </summary>
        LeftRectandgleMethod = 10, 

        /// <summary>
        /// Метод правых прямоугольников
        /// </summary>
        RightRectangleMethod = 20, 

        /// <summary>
        /// Метод центральных прямоугольников
        /// </summary>
        CentralRectanleMethod = 30, 

        /// <summary>
        /// Метод трапеций
        /// </summary>
        TrapeziumMethod = 40, 

        /// <summary>
        /// Метод Симпсона
        /// </summary>
        SimpsonMethod = 50
    }

    public static class EnumExtensions
    {
        public static string GetString(this CalculationType type) => type switch
            {
                CalculationType.LeftRectandgleMethod => "Метод левых прямоугольников",
                CalculationType.RightRectangleMethod => "Метод правых прямоугольников",
                CalculationType.CentralRectanleMethod => "Метод центральных прямоугольников",
                CalculationType.TrapeziumMethod => "Метод трапеций",
                CalculationType.SimpsonMethod => "Метод Симпсона",
                _ => string.Empty,
            };
    }
}

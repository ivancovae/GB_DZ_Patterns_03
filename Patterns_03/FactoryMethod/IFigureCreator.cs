namespace Patterns_03
{
    /// <summary>
    /// Интерфейс фабричного метода
    /// </summary>
    interface IFigureCreator
    {
        /// <summary>
        /// Фабричный метод
        /// </summary>
        /// <returns></returns>
        IFigure Create();
    }
}

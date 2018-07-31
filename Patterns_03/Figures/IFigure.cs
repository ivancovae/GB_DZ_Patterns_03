using System.Drawing;
namespace Patterns_03
{
    /// <summary>
    /// Интерфейс фигуры
    /// </summary>
    interface IFigure
    {
        /// <summary>
        /// Свойство наименования фигуры
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Свойство позиции фигуры
        /// </summary>
        Point Position { get; }
        /// <summary>
        /// Свойство количества точек у фигуры
        /// </summary>
        int CountPoint { get; }
    }
}

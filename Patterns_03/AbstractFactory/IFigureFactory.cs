using System.Drawing;
namespace Patterns_03
{
    /// <summary>
    /// Интерфейс абстрактной фабрики
    /// </summary>
    interface IFigureFactory
    {
        /// <summary>
        /// Создание объекта по типу
        /// </summary>
        /// <param name="description">описание фигуры</param>
        /// <param name="position">позиция фигуры</param>
        /// <returns>объект фигуры</returns>
        IFigure CreateInstance(string description, Point position);
    }
}

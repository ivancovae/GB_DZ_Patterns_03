using System.Drawing;

namespace Patterns_03
{
    /// <summary>
    /// Класс создания прямоугольника через фабричный метод
    /// </summary>
    class RectangleCreator : IFigureCreator
    {
        /// <summary>
        /// Реализация фабричного метода
        /// </summary>
        /// <returns>объект прямоугольника</returns>
        public IFigure Create() => rectangle;

        private Rectangle rectangle;

        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="position">позиция фигуры</param>
        public RectangleCreator(Point position)
        {
            rectangle = new Rectangle(position);
        }
    }
}

using System.Drawing;

namespace Patterns_03
{
    /// <summary>
    /// Класс создания квадрата через фабричный метод
    /// </summary>
    class SquareCreator : IFigureCreator
    {
        /// <summary>
        /// Реализация фабричного метода
        /// </summary>
        /// <returns></returns>
        public IFigure Create() => square;

        private Square square;

        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="position">позиция фигуры</param>
        public SquareCreator(Point position)
        {
            square = new Square(position);
        }
    }
}

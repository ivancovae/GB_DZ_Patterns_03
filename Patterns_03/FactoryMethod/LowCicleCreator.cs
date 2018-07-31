using System.Drawing;

namespace Patterns_03
{
    /// <summary>
    /// Класс создания низкополигонального круга через фабричный метод
    /// </summary>
    class LowCicleCreator : IFigureCreator
    {
        /// <summary>
        /// Реализация фабричного метода
        /// </summary>
        /// <returns>объект низкополигонального круга</returns>
        public IFigure Create() => cicle;

        private LowCicle cicle;

        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="position">позиция фигуры</param>
        public LowCicleCreator(Point position)
        {
            cicle = new LowCicle(position);
        }
    }
}

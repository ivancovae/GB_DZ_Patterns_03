using System.Drawing;

namespace Patterns_03
{
    /// <summary>
    /// Класс Квадрата
    /// </summary>
    class Square : IFigure
    {
        private string _name = "Квадрат";
        /// <summary>
        /// Свойство наименования фигуры
        /// </summary>
        public string Name => _name;

        private Point _position;
        /// <summary>
        /// Свойство позиции фигуры
        /// </summary>
        public Point Position => _position;

        private int _countPoint;
        /// <summary>
        /// Свойство количества точек у фигуры
        /// </summary>
        public int CountPoint => _countPoint;

        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="position">позиция фигуры</param>
        public Square(Point position)
        {
            this._position = position;
            this._countPoint = 4;
        }

        /// <summary>
        /// Переопредеоение метода возврата строки
        /// </summary>
        /// <returns>строка описания объекта</returns>
        public override string ToString() => $" {Name} , количество точкек = { this.CountPoint }, позиция = { this.Position }";
    }
}

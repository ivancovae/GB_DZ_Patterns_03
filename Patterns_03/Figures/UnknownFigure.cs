using System.Drawing;

namespace Patterns_03
{
    /// <summary>
    /// Класс неизвестная фигура
    /// </summary>
    class UnknownFigure : IFigure
    {
        private string _name = "Неизвестная фигура";
        /// <summary>
        /// Свойство наименования фигуры
        /// </summary>
        public string Name => _name;

        private Point _position = new Point();
        /// <summary>
        /// Свойство позиции фигуры
        /// </summary>
        public Point Position => _position;

        private int _countPoint = 0;
        /// <summary>
        /// Свойство количества точек у фигуры
        /// </summary>
        public int CountPoint => _countPoint;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public UnknownFigure() { }

        /// <summary>
        /// Переопредеоение метода возврата строки
        /// </summary>
        /// <returns>строка описания объекта</returns>
        public override string ToString() => $" {Name} , количество точкек = { this.CountPoint }, позиция = { this.Position }";
    }
}

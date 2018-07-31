using System;
using System.Collections.Generic;
using System.Reflection;
using System.Drawing;

namespace Patterns_03
{
    /// <summary>
    /// Класс реализации фабрики фигур
    /// </summary>
    class FigureFactory : IFigureFactory
    {
        private Dictionary<string, Type> figures;

        /// <summary>
        /// Конструктор создания фабрики
        /// </summary>
        public FigureFactory()
        {
            LoadTypes();
        }
        
        /// <summary>
        /// Создание объекта по типу
        /// </summary>
        /// <param name="description">описание фигуры</param>
        /// <param name="position">позиция фигуры</param>
        /// <returns>объект фигуры</returns>
        public IFigure CreateInstance(string description, Point position)
        {
            Type t = GetTypeToCreate(description);
            if (t == null)
                return new UnknownFigure();
            return Activator.CreateInstance(t, position) as IFigure;
        }

        private Type GetTypeToCreate(string figureType)
        {
            foreach (var figure in figures)
            {
                if (figure.Key.Contains(figureType))
                {
                    return figures[figure.Key];
                }
            }
            return null;
        }

        private void LoadTypes()
        {
            figures = new Dictionary<string, Type>();
            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();
            foreach (Type type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof(IFigure).ToString()) != null)
                {
                    figures.Add(type.Name, type);
                }
            }
        }
    }
}

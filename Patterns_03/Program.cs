using System;
using System.Reflection;
using System.Drawing;

namespace Patterns_03
{
    class Program
    {
        private static IFigureFactory LoadFactory()
        {
            string factoryName = Properties.Settings.Default.DefaultFigureFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IFigureFactory;
        }

        static void Main(string[] args)
        {
            IFigureFactory figureFactory = LoadFactory();
            IFigure[] figures = {
                figureFactory.CreateInstance( "Rectangle" , new Point(0, 0)),
                figureFactory.CreateInstance( "Square" , new Point(20, 30)),
                figureFactory.CreateInstance( "Cicle" , new Point(33, 22))
            };
            foreach (var figure in figures)
            {
                Console.WriteLine($"Фигура: {figure.GetType()} , {figure} ");
            }

            IFigureCreator[] creators = {
                new RectangleCreator( new Point(10, 10) ),
                new SquareCreator( new Point(20, 10) )
            };

            foreach (IFigureCreator creator in creators)
            {
                Console.WriteLine($"Фигура: {creator.GetType()} , { creator.Create()} " );
            }
        }
    }
}

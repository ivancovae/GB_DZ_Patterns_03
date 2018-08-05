using System;
using System.Reflection;
using System.Drawing;
using System.Dynamic;

namespace Patterns_03
{
    class Program
    {
        /// <summary>
        /// Добавление свойств объекту
        /// </summary>
        /// <param name="dynObject">объект кому добавляем свойства</param>
        static void TestDynamic(dynamic dynObject)
        {
            dynObject.Listen =
              new Func<string>(() => Console.ReadLine());
            dynObject.Say =
              new Action<string>(s => Console.Write(s));
            dynObject.Say("What's your ID? ");
            dynObject.ID = dynObject.Listen();
            dynObject.Say("Hello, " + dynObject.ID + "." +
              Environment.NewLine);
            dynObject.NewField = "";
        }

        private static IFigureFactory LoadFactory()
        {
            string factoryName = Properties.Settings.Default.DefaultFigureFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IFigureFactory;
        }

        static void Main(string[] args)
        {
            // создание объекта с расширяемыми свойствами
            dynamic flex = new ExpandoObject();
            TestDynamic(flex);
            // предполагаю, что для добавления свойств произвольному объект требуется использовать DLR и
            // наследоваться от DynamicObject, так как ExpandoObject помечен как не наследуемый
            // Вариант реализации класса ElastoClass
            dynamic ec = new ElastoClass();
            TestDynamic(ec);

            IFigureFactory figureFactory = LoadFactory();
            IFigure[] figures = {
                figureFactory.CreateInstance( "Rectangle" , new Point(0, 0)),
                figureFactory.CreateInstance( "Square" , new Point(20, 30)),
                figureFactory.CreateInstance( "Box" , new Point(33, 22)),
                figureFactory.CreateInstance( "LowCicle" , new Point(33, 22))
            };
            foreach (var figure in figures)
            {
                Console.WriteLine($"Фигура: {figure.GetType()} , {figure} ");
            }

            IFigureCreator[] creators = {
                new RectangleCreator( new Point(10, 10) ),
                new LowCicleCreator( new Point(12, 15) ),
                new SquareCreator( new Point(20, 10) )
            };

            foreach (IFigureCreator creator in creators)
            {
                Console.WriteLine($"Фигура: {creator.GetType()} , { creator.Create()} " );
            }
        }
    }
}

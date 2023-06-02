using MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMain
{
    public class MainClass
    {
        public static void Main() 
        {
            List<double> list = new List<double>()
            {
                1, 2, 3, 4, 5, 6, 7
            };
            List<double> result = AlgebraClass.SolveSquareRootEquation(-1, 2, -5);
            string resultString = string.Join("  ", result);
            //
            Console.WriteLine("Блок Алгебра");
            Console.WriteLine("Корни x1,x2: " + resultString);
            Console.WriteLine("Корень х: " + AlgebraClass.SolveLinearEquation(11, 4));
            Console.WriteLine("Сумма ряда: " + AlgebraClass.SumSeries(list));
            Console.WriteLine("Максимальное число ряда: " + AlgebraClass.MaxSeries(list));
            //
            Console.WriteLine("Среднее число ряда: " + AlgebraClass.AvgSeries(list));
            Console.WriteLine("Блок Геометрии");
            Console.WriteLine("S треугольника: " + GeometryClass.TriangleArea(11, 2));
            Console.WriteLine("S прямоугольного треугольника: " + GeometryClass.RightTriangleArea(6, 3));
            Console.WriteLine("S прямоугольника: " + GeometryClass.RectangleArea(5, 6));
            Console.WriteLine("S круга: " + GeometryClass.CircleArea(5.3));
            Console.WriteLine("S трапеции: " + GeometryClass.TrapezoidArea(8, 7, 6));
           
            double a = 15;
            double b = 23; 
            double c = 44;
            //
            Console.WriteLine("Блок Тригонометрии");
            Console.WriteLine("Sin: " + TrigonometryClass.SinValue(a, b, c));
            Console.WriteLine("Cos: " + TrigonometryClass.CosValue(a, b, c));
            Console.WriteLine("Tg: " + TrigonometryClass.TanValue(a, b, c));
            Console.WriteLine("Ctg: " + TrigonometryClass.CotanValue(a, b, c));
            Console.WriteLine("Arcsin: " + TrigonometryClass.ArcsinValue(a, b, c));
        }
    }
}

/*
C# for Grandchildren: educational console application
Площадь треугольника по координатам (PointsTriangleArea)

Задача: 
Треугольник задан координатами своих вершин: (x1, y1), (x2, y2), (x3, y3).
Вычислить площадь треугольника.
*/

/*
*/
using System.Drawing;
using static System.Console;

using static ConsoleLibrary.ConsoleApp;
using static ConsoleLibrary.ConsoleIO;

WriteAppTitle("Площадь треугольника по координатам");
Run(Action);
PromptExitApp();

void Action()
{
    PointF point1 = ReadPointF("Введите координаты точки 1");
    PointF point2 = ReadPointF("Введите координаты точки 2");
    
    double a = Math.Sqrt((point2.X - point1.X) * (point2.X - point1.X) +
        (point2.Y - point1.Y) * (point2.Y - point1.Y));
    WriteLine(a);
}

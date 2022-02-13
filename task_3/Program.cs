﻿//Найти расстояние между точками в пространстве 2D/3D
double Coards(double arg)
{
    arg = new Random().Next(1, 100);
    return arg;
}

// Получаем значения для координат из рандома
double num = 0;
double x1 = Coards(num);
double x2 = Coards(num);
double y1 = Coards(num);
double y2 = Coards(num);
double z1 = Coards(num);
double z2 = Coards(num);

// Сравниваем какая из координат больше, для формулы вычисления расстояния
// присваиваем значения каждой координаты

if (x1 > x2)
{
    double temp = x1;
    x1 = x2;
    x2 = temp;
}

if (y1 > y2)
{
    double temp = y1;
    y1 = y2;
    y2 = temp;
}

if (z1 > z2)
{
    double temp = z1;
    z1 = z2;
    z2 = temp;
}

// Выводим правильное расположение координат 2d = 3d, где z1 == 0 и z2 == 0
Console.WriteLine($"Координата в пространстве 2d: x1={x1}, x2={x2}, y1={y1}, y2={y2}");

// Выводим правильное расположение координат 3d
Console.WriteLine($"Координата в пространстве 3d: x1={x1}, x2={x2}, y1={y1}, y2={y2}, z1={z1}, z2={z2}");

// вычисляем корень из суммы длин 2d
double distance2D = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
Console.WriteLine($"Расстояние между точками в пространстве 2d = {distance2D}");

// вычисляем корень из суммы длин 3d
double distance3D = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1)));
Console.WriteLine($"Расстояние между точками в пространстве 3d = {distance3D}");

   
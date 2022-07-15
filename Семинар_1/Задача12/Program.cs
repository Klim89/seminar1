//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.



void Zadacha12()
{
    Console.WriteLine("Введите координаты первой точки");
    Console.WriteLine("x:");
    double x1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("y:");
    double y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Координата точки ({x1},{y1})");

    Console.WriteLine("Введите координаты второй точки");
    Console.WriteLine("x:");
    double x2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("y:");
    double y2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Координата точки ({x2},{y2})");
    double dist = 0;

    dist = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
    Console.WriteLine($"Расстояние между точками ({dist})");
}
//Zadacha12();

void Zadacha12_1()
{
Console.WriteLine("Ввдедите координаты первой точки");
    double x1 = Convert.ToInt32(Console.ReadLine());
    double y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ввдедите координаты второй точки");
    double x2 = Convert.ToInt32(Console.ReadLine());
    double y2 = Convert.ToInt32(Console.ReadLine());

    double xx = x2 - x1;
    double yy = y2 - y1;

    double result = Math.Sqrt(xx*xx + yy*yy);
    Console.WriteLine("Расстояние:" + result);

}
//adacha12_1();


void Zadacha12_2()
{

    Random random = new Random();
    int x1 = random.Next(0, 100);
    int y1 = random.Next(0, 100);
    int x2 = random.Next(0, 100);
    int y2 = random.Next(0, 100);
    Console.WriteLine($"Координаты точки 1 ({x1} , {y1}) и точки 2 ({x2} , {y2})");
    double dist = Math.Sqrt(Math.Pow(x2 - x1, 2)+ Math.Pow(y2 - y1, 2));
    Console.WriteLine($"Расстояние ({Math.Round(dist,2)})");

}

Zadacha12_2();

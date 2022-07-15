//17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void Zadacha10()
{
    Random random = new Random();
    int x = random.Next(-10, 11);
    int y = random.Next(-10, 11);
    Console.Write($"точка с координатами ({x}, {y})");
    if (x>0 && y>0) Console.WriteLine("1 четверть");
    else if (x<0 && y>0) Console.WriteLine("2 четверть");
    else if (x<0 && y<0) Console.WriteLine("3 четверть");
    else if (x>0 && y<0) Console.WriteLine("4 четверть");
    else Console.WriteLine("точка лежит на оси координат");
}
Zadacha10(); 
// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

int number = 3;
int start = -number;
while (start < number)
{
    Console.Write(start + "  ");
    start++;
}
Console.Write(number);


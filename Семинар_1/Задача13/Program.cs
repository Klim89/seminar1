// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

void Zadacha13()
{
    Console.Write("Введите число N: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    int i = 1;
   
    while (i <= number2)
    {
    double result = Math.Pow(i, 2);
    Console.Write(result + " ");
    i++;
    }
}
Zadacha13();
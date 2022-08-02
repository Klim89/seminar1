// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

void Zadacha14()
{
    Console.WriteLine("Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А. ");
    Console.WriteLine("Введите число А: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    for (int i = 0; i <= number; i++)
    {
        sum += i;
    }

    Console.Write($"Сумма чисел от 1 до {number} равна {sum}");
        
    
}
Zadacha14();

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

void Zadacha15()
{
    
   Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());    
        int i;
        for (i = 0; number > 0; i++)
        {
            number=number/10;
        }
        Console.WriteLine($"В числе {i} цифр(ы)");   
    
}
// Zadacha15();


void Zadacha15_1()
{
Console.WriteLine("Введите натуральное число");
        int N = Convert.ToInt32(Console.ReadLine());    
        int i = 0;

        while (N>0)
        {
            N=N/10;
            i++;
        }
        Console.WriteLine($"В числе {i} цифр(ы)");
}

// void Zadacha15_1()
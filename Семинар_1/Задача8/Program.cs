// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

void Zadacha08()
{
    Console.Write("Введите число для проверки кратности: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число 2: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число 3: ");
    int number3 = Convert.ToInt32(Console.ReadLine());
    
    if (number1 % number2 == 0 && number1 % number3 == 0)
    {
    Console.WriteLine(number1 + " - является кратным" + " " + number2 + " и " + number3);
    }
    else
    {
    Console.WriteLine(number1 + " - не является кратным" + " " + number2 + " и " + number3);
    }   
}

Zadacha08();
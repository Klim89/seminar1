//  Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

void Zadacha07()
{
    Console.Write("Введите число 1: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число 2: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    int div = number2 % number1;
    if (div == 0)
    {
    Console.WriteLine(number2 + " - является кратным" + " " + number1);
    }
    else
    {
    Console.WriteLine(number2 + " - не является кратным" + " " + number1);
    Console.WriteLine(div);
    }   

}

Zadacha07();
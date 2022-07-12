// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.


void Zadacha09()
{
    Console.Write("Введите число 1: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число 2: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    
    if (number1 == number2*number2)
        {
            Console.WriteLine(number1 + " - является квадратом" + " " + " "+ number2);
        }
    else if (number2 == number1*number1)
        {
        Console.WriteLine(number2 + " - является квадратом" + " " + " "+ number1);
        }
    else 
        {
            Console.WriteLine(number1 + " - не является квадратом"  + " "+ number2);
            Console.WriteLine(number2 + " - не является квадратом"  + " "+ number1);
        }   
    }


Zadacha09();

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

void Zadacha06()
{
    Random rand = new Random();

    int number = rand.Next(100, 1000);
    Console.WriteLine(number);
    int ones = number % 10;
    int tens = number / 10;
    int hungs = number / 100;

    int resultNumber = ones + hungs * 10;
    Console.WriteLine(resultNumber);
}

Zadacha06();

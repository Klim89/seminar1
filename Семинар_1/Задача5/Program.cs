// Напишите программу, которая выводит случайное число из 
// отрезка [10, 99] и показывает наибольшую цифру числа.

void Zadacha05()
{

    Random rand = new Random();
    
    //<Тип данных> имя = new <тип данных>();
    int number = rand.Next(10,100);
    Console.WriteLine(number);
    //84
    int ones = number % 10; // 84 % 10 = 4
    int tens = number / 10; // 84 / 10 = 8
   
    if (ones > tens) Console.WriteLine(ones);
    else Console.WriteLine(tens);

}

Zadacha05();

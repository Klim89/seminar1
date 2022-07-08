// функция возведения в квадрат
void Zadacha5()
{
int number = 5;
int result = Power(number);
Console.WriteLine(result);
}

int Power(int currentNumber)
{
    return currentNumber * currentNumber;
}

Console.WriteLine("Тут будет число 16. Смотрим: " + Power(4));



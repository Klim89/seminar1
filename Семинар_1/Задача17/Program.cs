// //Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


void Zadacha17()
{
    int size = 8;
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(0, 2);
        Console.Write($"{array[i]} ");
    }
}

Zadacha17();


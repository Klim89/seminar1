// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// void Zadacha16()
// {

//    Console.WriteLine("Введите число");
//         int number = Convert.ToInt32(Console.ReadLine());
//         int fact = 1;
//         for (int i = 1; i <= number; i++)
//         {
//             fact = fact*i;
//         }
//         Console.WriteLine($"Произведение чисел от 1 до {number} равно: {fact}");
// }
// Zadacha16();

void Zadacha16_1()
{
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine()),
        inum = 0;
    int anum = 1,
        bnum = 2;
    while (inum < num - 1)
    {
        int res = anum * bnum;
        anum = anum * bnum;
        bnum++;
        inum++;
    }
    Console.WriteLine(anum + " * " + bnum + " = " + res);
}
//Zadacha16_1();



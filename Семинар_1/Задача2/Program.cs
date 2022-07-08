Console.Write("Введите число дня недели: ");
int number_week = Convert.ToInt32(Console.ReadLine());

if(number_week == 1)
{
    Console.WriteLine("Понедельник");
}
 else if(number_week == 2)
{
    Console.WriteLine("Вторник");
}
else if(number_week == 3)
{
    Console.WriteLine("Среда");
}
else if(number_week == 4)
{
    Console.WriteLine("Четверг");
}
else if(number_week == 5)
{
    Console.WriteLine("Пятница");
}
else if(number_week == 6)
{
    Console.WriteLine("Суббота");
}
else if(number_week == 7)
{
    Console.WriteLine("Воскресение");
}
else
{
    Console.WriteLine("Указано некорректное число недели");

}
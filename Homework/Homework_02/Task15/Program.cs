Console.Write("Введите цифру от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

Console.Write("Сегодня выходной? ");

if(day > 0 && day < 6)
{
    Console.Write("нет.");
}

if(day > 5 && day < 8 )
{
    Console.Write("да.");
}

if(day < 1 && day > 8)
{
    Console.Write("такого дня недели не существует.");
}


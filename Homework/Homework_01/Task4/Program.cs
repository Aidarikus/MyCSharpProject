int a = 2,  b = 3,  c = 7,
    d = 44,  e = 5,   f = 78,
    g = 22, h = 3,  i = 9;



if (a > b && a > c)
{
    Console.WriteLine("Первое максимальное число: " + a);
}



if (b > a && b > c)
{
    Console.WriteLine("Первое максимальное число: " + b);
}

if (c > a && c > b)
{
    Console.WriteLine("Первое максимальное число: " + c);
}



if (d > e && d > f)
{
    Console.WriteLine("Второе максимальное число: " + d);
}

if (e > d && e > f)
{
    Console.WriteLine("Второе максимальное число: " + d);
}

if (f > e && f > d)
{
    Console.WriteLine("Второе максимальное число: " + f);
}



if (g > h && g > i)
{
    Console.WriteLine("Третье максимальное число: " + g);
}

if (h > g && h > i)
{
    Console.WriteLine("Третье максимальное число: " + h);
}

if (i > h && i > g)
{
    Console.WriteLine("Третье максимальное число: " + i);
}
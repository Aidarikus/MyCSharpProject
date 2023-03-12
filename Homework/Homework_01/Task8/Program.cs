int a = 5;
int b = 8;
int count = 1;

Console.WriteLine("Четные числа от 1 до числа 5: ");

while(count < a+1)
{
    if(count%2 == 0)
    {
        Console.WriteLine(count);    
    }
    count++;
}

count = 1;

Console.WriteLine("Четные числа от 1 до числа 8: ");

while(count < b+1)
{
    if(count%2 == 0)
    {
        Console.WriteLine(count);    
    }
    count++;
}
int [] array = { 4, -3, 7};
int lenght = array.Length;
int index = 0;

Console. WriteLine("Четными числами являются: ");

while (index < lenght)
{
    if(array[index]%2 == 0)
    {
        Console.WriteLine(array[index]);
    }
    index++;
}
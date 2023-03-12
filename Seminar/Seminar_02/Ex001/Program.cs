int [] arr = {2, 5, 6, 10, 32, 30};
int length = arr.Length;

int count = 0;
int index = 0;

while(index < length)
{
    if(arr[count]%5 == 0)
    {
        count++;
    }
}

index = 0;

int [] arr2 = new int [count];

int index2 = 0;

while(index < length)
{
    if(arr[index]%5 == 0)
    {
        arr2[index2] = arr[index];
        index2++;
    }
    index++;
}

index2 = 0;

while(index2 < count)
{
    Console.WriteLine(arr2[index2]);
    index2++;
}
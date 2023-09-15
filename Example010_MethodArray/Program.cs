int[] array = { 15, 32, 32, 18, 45, 36, 27, 18};

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index + 1;
}


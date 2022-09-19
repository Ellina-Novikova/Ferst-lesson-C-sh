// Поискэлемента массива, равного Find
//              0     1   2   3   4   5   6   7
int[] array = {100, 122, 13, 42, 25, 64, 17, 83};
int n = array.Length;
int find = 122;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

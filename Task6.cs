Console.WriteLine("enter the number of row:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the number of column:");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
int[] collect = new int[n * m];

for (int i = 0; i < n; i++)
{
    int j = 0;
    while (j < m)
    {
        Random rnd = new Random();
        int value = rnd.Next(1, n * m * 5 + 1);
        int result = checking(i, j, value);
        if (result == 1)
        {
            j += 1;
        }
    }
}


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

int checking(int i, int j, int value)
{
    for (int k = 0; k < n * m; k++)
    {
        if (collect[k] == value)
        {
            return 0;
        }
        else if (collect[k] == 0)
        {
            break;
        }
    }
    collect[i * m + j] = value;
    matrix[i, j] = value;
    return 1;
}
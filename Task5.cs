int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int a = matrix.GetLength(0);
int b = matrix.GetLength(1);
int count = 0;

for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        checkingValues(i, j);
    }
}
if (count == 0)
{
    Console.WriteLine("no");
}

void checkingValues(int row, int column)
{
    int max = matrix[row, 0];
    for (int i = 0; i < b; i++)
    {
        if (matrix[row, i] > max)
        {
            max = matrix[row, i];
        }
    }
    if (matrix[row, column] == max)
    {
        int min = matrix[0, column];
        for (int j = 0; j < a; j++)
        {
            if (matrix[j, column] < min)
            {
                min = matrix[j, column];
            }
        }
        if (matrix[row, column] == min)
        {
            count++;
            Console.WriteLine("The row is " + row);
            Console.WriteLine("The column is " + column);
            Console.WriteLine("The value is " + matrix[row, column]);
            Console.WriteLine();
        }
    }
}
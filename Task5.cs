int[,] matrix = { { 1, 2, 3, 4, 4 }, { 4, 5, 6, 10, 5 } };
int a = matrix.GetLength(0);
int b = matrix.GetLength(1);

for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        checkingValues(i, j);
    }
}

void checkingValues(int row, int column)
{
    int max = matrix[row, 0];
    for (int i = 0; i < b; i++)
    {
        if (matrix[row,i] > max)
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
            Console.WriteLine("The row is " + row);
            Console.WriteLine("The column is " + column);
            Console.WriteLine("The value is " + matrix[row, column]);
            Console.WriteLine();
        }
    }
}
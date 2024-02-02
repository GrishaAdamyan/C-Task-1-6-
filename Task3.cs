Console.WriteLine("enter the number of row:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the number of column:");
int b = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[8, 8];
int flag = 0;

do
{
    int count = addingQueen(a, b);
    if (count == 2)
    {
        flag = 1;
    }
    Random rnd = new Random();
    int index = rnd.Next(2, count + 1);
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            if (matrix[i, j] == index)
            {
                a = i;
                b = j;
                break;
            }
        }
    }
}
while (flag == 0);

Console.WriteLine();
for (int i = 0; i < 8; i++)
{
    for (int j = 0; j < 8; j++)
    {
        if (matrix[i, j] == 777)
        {
            Console.Write("Q ");
        }
        else
        {
            Console.Write(matrix[i, j] + " ");
        }
    }
    Console.WriteLine();
}

int addingQueen(int a, int b)
{
    int count = 2;
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            if (a == i && b == j)
            {
                matrix[i, j] = 777;
            }
            else if (matrix[i, j] == 1 || matrix[i, j] == 777)
            {
                continue;
            }
            else if ((Math.Abs(a - i) == Math.Abs(b - j)) || a == i || b == j)
            {
                matrix[i, j] = 1;
            }
            else
            {
                matrix[i, j] = count;
                count++;
            }
        }
    }
    return count;
}
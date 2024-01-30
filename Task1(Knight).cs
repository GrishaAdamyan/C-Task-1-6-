//1 version

/*Console.WriteLine("enter the number of row:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the number of column:");
int b = Convert.ToInt32(Console.ReadLine());


if (((9 > (a - 2)) && ((a - 2) > 0) && (9 > (b - 1)) && ((b - 1) > 0)))
{
    Console.WriteLine("the number of row is " + (a - 2));
    Console.WriteLine("the number of column is " + (b - 1));
}
if (((9 > (a - 2)) && ((a - 2) > 0) && (9 > (b + 1)) && ((b + 1) > 0)))
{
    Console.WriteLine("the number of row is " + (a - 2));
    Console.WriteLine("the number of column is " + (b + 1));
}
if (((9 > (a - 1)) && ((a - 1) > 0) && (9 > (b - 2)) && ((b - 2) > 0)))
{
    Console.WriteLine("the number of row is " + (a - 1));
    Console.WriteLine("the number of column is " + (b - 2));
}
if (((9 > (a - 1)) && ((a - 1) > 0) && (9 > (b + 2)) && ((b + 2) > 0)))
{
    Console.WriteLine("the number of row is " + (a - 1));
    Console.WriteLine("the number of column is " + (b + 2));
}
if (((9 > (a + 1)) && ((a + 1) > 0) && (9 > (b - 2)) && ((b - 2) > 0)))
{
    Console.WriteLine("the number of row is " + (a + 1));
    Console.WriteLine("the number of column is " + (b - 2));
}
if (((9 > (a + 1)) && ((a + 1) > 0) && (9 > (b + 2)) && ((b + 2) > 0)))
{
    Console.WriteLine("the number of row is " + (a + 1));
    Console.WriteLine("the number of column is " + (b + 2));
}
if (((9 > (a + 2)) && ((a + 2) > 0) && (9 > (b - 1)) && ((b - 1) > 0)))
{
    Console.WriteLine("the number of row is " + (a + 2));
    Console.WriteLine("the number of column is " + (b - 1));
}
if (((9 > (a + 2)) && ((a + 2) > 0) && (9 > (b + 1)) && ((b + 1) > 0)))
{
    Console.WriteLine("the number of row is " + (a + 2));
    Console.WriteLine("the number of column is " + (b + 1));
}*/




//2 version

/*Console.WriteLine("enter the number of row:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the number of column:");
int b = Convert.ToInt32(Console.ReadLine());


for (int i = 1; i < 9; i++)
{
    for (int j = 1; j < 9; j++)
    {
        if ((Math.Abs(a - i) == 2 && Math.Abs(b - j) == 1) || (Math.Abs(a - i) == 1 && Math.Abs(b - j) == 2))
        {
            Console.Write("1 ");
        }
        else if (a == i && b == j)
        {
            Console.Write("K ");
        }
        else
        {
            Console.Write("0 ");
        }
    }
    Console.WriteLine();
}*/
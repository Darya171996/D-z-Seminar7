// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.

//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.WriteLine("Ведите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double result = new Random().NextDouble() + new Random().Next(-10, 10);

        array[i,j]= Math.Round(result, 3);
        Console.Write($"{array[i, j]} ");
        
    }
    Console.WriteLine();
}


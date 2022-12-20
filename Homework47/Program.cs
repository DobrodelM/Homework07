/*
Задача 47.
Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
int GetNumberFromUser(string message)
{
    int number = 0;
    Console.WriteLine(message);
    number = Convert.ToInt32(Console.ReadLine());
    return number;
}
double[,] generate2DArray(int lengthRow, int lengthCol, int deviation)
{
    double[,] array = new double[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-deviation, deviation + 1) / 10.0);
        }
    }
    return array;
}
void printColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(information);
    Console.ResetColor();
}
void print2dArray(double[,] array)
{
    Console.Write("\t");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printColor(i + "\t", ConsoleColor.DarkGreen);
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printColor(i + "\t", ConsoleColor.DarkGreen);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int m = GetNumberFromUser("Введите количество (m) строк в массиве");
int n = GetNumberFromUser("Введите количество (n) столбцов в массиве");
double[,] array = generate2DArray(m, n, 100);
print2dArray(array);

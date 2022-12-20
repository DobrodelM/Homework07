/*
Задача 52.
Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int GetNumberFromUser(string message)
{
    int number = 0;
    Console.WriteLine(message);
    number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] generate2DArray(int lengthRow, int lengthCol, int deviation)
{
    int[,] array = new int[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().Next(-deviation, deviation + 1);
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
void print2dArray(int[,] array)
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
double midSumArray(int[,] new2DArray)
{
    string line = " ";
    int sum  = 0;
    double midAr = 0;
    for (int j = 0; j < new2DArray.GetLength(1); j++)
    {
        for (int i = 0; i < new2DArray.GetLength(0); i++)
        {
            sum += new2DArray[i, j];
            Console.WriteLine(sum);
            midAr = Convert.ToDouble(sum / i);
            Console.WriteLine(midAr);
            line = line + midAr;
        }
       
    }
    return line;
}

int m = GetNumberFromUser("Введите количество (m) строк в массиве");
int n = GetNumberFromUser("Введите количество (n) столбцов в массиве");
int[,] array = generate2DArray(m, n, 100);
print2dArray(array);
Console.WriteLine();
double midAr = midSumArray(array);
Console.WriteLine(line);
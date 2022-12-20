/*
Задача 50.
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4
9 -> 4
5 -> 9
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

void print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
/*
int (или войд метод) FindNumber(int[,] new2DArray, int number)
{
    int что-то там = 0;
    for (int i = 0; i < new2DArray.GetLength(0); i++)
    {
        for (int j = 0; j < new2DArray.GetLength(1); j++)
        {
            if(number == формула перевода)
            {
                number = array[i,j];
                Console.WriteLine("");
            }
            else
            Console.WriteLine("Такого числа в массиве нет");
        }
    }
    return что-то там;
}
*/
int m = GetNumberFromUser("Введите количество (m) строк в массиве");
int n = GetNumberFromUser("Введите количество (n) столбцов в массиве");
int[,] array = generate2DArray(m, n, 100);
print2dArray(array);
Console.WriteLine();
// int number = GetNumberFromUser("Введите номер элемента массива: ");
// int findNumber = FindNumber(array, number);
// Console.WriteLine(findNumber);
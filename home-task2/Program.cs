/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

using static MyMethod.MyMethod;
using MyMethod;

MyGenerate gen = new MyGenerate();

double[,] usersArray = gen.ArrayGenDD();
Print(usersArray);

int rowPos = IntInput($"В какой строке ищем значение? (1...{usersArray.GetLength(0)})");
int columnsPos = IntInput($"В каком столбце ищем значение? (1...{usersArray.GetLength(1)})");

try
{
    double seekNumber = FindIn2DArrayByIndex(usersArray, rowPos, columnsPos);
    Print($"Искомое число {seekNumber}");
}
catch (IndexOutOfRangeException e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Print($"Произошла ошибка : {e.Message}");
    Console.ResetColor();
}

double FindIn2DArrayByIndex(double[,] usersArray, int row, int column)
{
    int rows = usersArray.GetLength(0);
    int columns = usersArray.GetLength(1);
    if (row > rows)
    {
        throw new IndexOutOfRangeException("В массиве нет такого количества строк");
    }
    if (column > columns)
    {
        throw new IndexOutOfRangeException("В массиве нет такого количества столбцов");
    }

    return usersArray[row - 1, column - 1];


}

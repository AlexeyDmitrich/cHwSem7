/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

using static MyMethod.MyMethod;
using MyMethod;

MyGenerate gen = new MyGenerate();

int[,] usersArray = gen.ArrayGenDI();
Print(usersArray);
double[] columnsAbs = AbsInArray(usersArray);
Print(columnsAbs);

double[] AbsInArray(int[,] usersArray)
{
    double[] sum = new double[usersArray.GetLength(1)];
    double[] abs = new double[usersArray.GetLength(1)]; ;
    for (int i = 0; i < usersArray.GetLength(1); i++)
    {
        for (int j = 0; j < usersArray.GetLength(0); j++)
        {
            sum[i] += usersArray[j, i];
            //Print($"сумма: {sum[i]}");
        }
        //Print("--------------");  
    }
    for (int i = 0; i < sum.Length; i++)
    {
        abs[i] = Math.Round((sum[i] / sum.Length), 1);
    }
    return abs;
}

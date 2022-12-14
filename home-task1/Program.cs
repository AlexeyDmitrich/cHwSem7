using static MyMethod.MyMethod;
/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
Random rnd = new Random();

double[,] myArray = ArrayGenDD();
Print(myArray);

double[,] ArrayGenDD()
    {
        int rows = IntInput("число строк");
        int columns = IntInput("число столбцов");
        int min = IntInput("минимальное значение");
        int max = IntInput("максимальное значение");
        double[,] array = new double[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j= 0; j < columns; j++){
                array[i,j] = Math.Round(((rnd.NextDouble())*rnd.Next(min,max)), 1);
            }  
        }
        // отладка:
        // my.Print(array);
        return array;
    }
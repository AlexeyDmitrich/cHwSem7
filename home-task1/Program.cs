using static MyMethod.MyMethod;
/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
Random rnd = new Random();

int rows = IntInput("число строк");
int columns = IntInput("число столбцов");
int min = IntInput("минимальное значение");
int max = IntInput("максимальное значение");

double[,] myArray = ArrayGenDD(rows, columns, min, max);
Print(myArray);

/// <summary>
/// Метод для генерации двумерного массива заполненного случайными числами с ограничениями
/// </summary>
/// <param name="rows">Число строк</param>
/// <param name="columns">Число столбцов</param>
/// <param name="min">Минимально-допустимое значение</param>
/// <param name="max">Максимально-допустимое значение</param>
/// <returns>Массив формата double[,]</returns>
double[,] ArrayGenDD(int rows, int columns, int min, int max)
    {
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

// метод отправляется в копилочку методов
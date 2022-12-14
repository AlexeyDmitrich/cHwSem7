using static MyMethod.MyMethod;
Random rnd = new Random();

/*
Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса нечётные, и замените эти элементы на их
квадраты.
Например, изначально массив выглядел вот так:
1 47 2
5 92 3
8 42 4
Новый массив будет выглядеть вот так:
1 47 2
5 81 9
8 42 4
*/

double[,] myArray = Create2dArray(7, 7);
Print(myArray);
Print(EditeArray(myArray));

double[,] EditeArray(double[,] usersArray)
{
    double[,] array = new double[usersArray.GetLength(0), usersArray.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
            {
                array[i, j] = Math.Pow(usersArray[i, j], 2);
            }
            else
            {
                array[i, j] = usersArray[i, j];
            }
        }
    }
    return array;
}

double[,] Create2dArray(int countOfRows, int countOfColumns)
{
    double[,] array = new double[countOfRows, countOfColumns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 10);
        }
    }
    return array;
}

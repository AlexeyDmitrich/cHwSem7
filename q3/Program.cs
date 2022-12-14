using static MyMethod.MyMethod;
Random rnd = new Random();

/*
Задача 51: Задайте двумерный массив. 
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

int m = IntInput("Длину стороны матрицы");
//int n = IntInput("Значение для n");

double[,] myArray = Create2dArray(m,m);
Print(myArray);
Print($"Сумма элементов главной диагонали: {SumArraysElements(myArray)}");

int SumArraysElements (double[,] usersArray){
    int counter = 0;
    for (int i = 0; i < usersArray.GetLength(0); i++){
                counter += (int)(usersArray[i,i]);
        }
    return counter;
}

double [,] Create2dArray (int countOfRows, int countOfColumns){
    double [,] array = new double [countOfRows,countOfColumns];
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i,j] = rnd.Next(-10, 10);
        }
    }
    return array;
}

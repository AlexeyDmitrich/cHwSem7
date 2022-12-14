using static MyMethod.MyMethod;

/*
Задача 48: Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₙₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4. 
0 1 23
1 2 34
2 3 45
*/
int m = IntInput("Значение для m");
int n = IntInput("Значение для n");

int[,] myArray = Create2dArray(m,n);
Print(myArray);

int [,] Create2dArray (int countOfRows, int countOfColumns){
    int [,] array = new int [countOfRows,countOfColumns];
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i,j] = i+j;
        }
    }
    return array;
}

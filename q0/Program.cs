using static MyMethod.MyMethod;
Random rnd = new Random();

int[,] myArray = create2dArray(5,6);
Print(myArray);

int [,] create2dArray (int countOfRows, int countOfColumns){
    int [,] array = new int [countOfRows,countOfColumns];
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(0); j++){
            array[i,j] = rnd.Next(-10,10);
        }
    }
    return array;
}

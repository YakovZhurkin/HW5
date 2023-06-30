// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] Array = newArray(5);
Console.WriteLine($"difference = {checkDif(Array)}");


double[] newArray(int size)     // метод создания массива дабл
{

double[] myArray = new double[size]; 
Console.WriteLine("Массив задан : ");

for (int i = 0; i < myArray.Length; i++)
{
myArray[i] = new Random().NextDouble()* new Random().Next(10,100);
// myArray[i]= Math.Round(myArray[i],3); !!!!!!//ограничение цифр после запятой
Console.Write(myArray[i] + "|"); 

}
return myArray;
}

double checkDif(double[] array)
{
    double min = array[0];
    double max = array[0];
    for( int i = 0; i<array.Length;i++)
    {
        if(min>array[i]) min=array[i];
        if(max<array[i]) max=array[i];
    }
    return max - min;
}


// int Length = 8; 
// int min = 10; 
// int max = 100;

// double[] myArray = new double[Length]; //  создал массив и задал его длинну
//  Random myRandom = new Random();  // обозвал масис (myRandom)
// Console.WriteLine("Массив задан : ");
// for (int i = 0; i < myArray.Length; i++) // вывод массива на экран через функцию for
// {
// myArray[i] = myRandom.NextDouble(); // проставил ограничение массива
// Console.Write(myArray[i] + "|"); //вывод массива через " "
// }
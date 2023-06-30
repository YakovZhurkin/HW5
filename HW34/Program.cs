// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int Length = 8; //можно прописать через Prompt
int min = 100; //можно прописать через Prompt(диапозон меньшее)
int max = 1000; //можно прописать через Prompt(диапозон большее)

int[] array = new int[8]; //  создал массив и задал его длинну
 Random myRandom = new Random();  // обозвал масис (myRandom)
Console.WriteLine("Массив задан : ");
for (int i = 0; i < array.Length; i++) // вывод массива на экран через функцию for
{
array[i] = myRandom.Next(min,max); // проставил ограничение массива
Console.Write(array[i] + " "); //вывод массива через " "
}
int count = 0;
for (int i = 0; i < array.Length; i++) // перебор массива
{
    
if (array[i]%2==0)   // функция счетчика четных
{
 count++; 
}

}
Console.WriteLine( );
Console.Write(count);
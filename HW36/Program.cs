// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int Length = 10; //можно прописать через Prompt
int min = -100 ; //можно прописать через Prompt(диапозон меньшее)
int max =  100; //можно прописать через Prompt(диапозон большее)

int[] array = new int[Length]; 
 Random myRandom = new Random();  
Console.WriteLine("Массив задан : ");
for (int i = 0; i < array.Length; i++) 
{
array[i] = myRandom.Next(min,max); 
Console.Write(array[i] + " ");
}

int sum = 0;
for (int i= 0; i < array.Length;i++)
{
    if (i%2 != 0)
    sum = sum + array[i];
}
Console.WriteLine(sum);

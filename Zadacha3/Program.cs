/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] numbers = new int [n,m];
FillNumbers(numbers);
for (int j = 0; j < numbers.GetLength(1); j++)
{
   double arefMetik = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        arefMetik = (arefMetik+numbers[i,j]);
    }
    arefMetik = arefMetik/n;
    System.Console.WriteLine(arefMetik + ";");
}
PrintArray(numbers);

void FillNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(minValue: 1, maxValue: 10);
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        System.Console.WriteLine(); 
    }
}

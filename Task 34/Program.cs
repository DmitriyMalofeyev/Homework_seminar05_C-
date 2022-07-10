// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.


Console.WriteLine("Введите желаемое число N элементов массива"); 
int N = Convert.ToInt32(Console.ReadLine());

int[] result = new int[N];
Random rnd = new Random();
int sumEven = 0;
Console.Write("Определен массив: ");
for (int i = 0; i < N; i++)
{
    result[i] = rnd.Next(100, 1000);
    Console.Write(result[i]+" "); 
    if (result[i] % 2 == 0)
    {
        sumEven++;     
    }
    
}

Console.WriteLine("\nКоличество четных чисел в массиве: {0}", sumEven);

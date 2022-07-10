// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите желаемое число N элементов массива"); 
int N = Convert.ToInt32(Console.ReadLine());

double[] result = new double[N];
Random rnd = new Random();
double max = result[0];
double min = result[0];

Console.Write("Определен массив: ");
for (int i = 0; i < N; i++)
{
    result[i] = rnd.Next(-100, 101); //  диапазон ограничен -100 и 100
    Console.Write(result[i]+" "); 

    if (result[i] >= max) 
    {
        max = result[i];     
    }
    if (result[i] <= min)
    {
        min = result[i];
    }
    
}
double difff = max - min;
Console.Write("\nРазница между max и min равна "+ difff);



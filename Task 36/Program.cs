// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите желаемое число N элементов массива"); 
int N = Convert.ToInt32(Console.ReadLine());

int[] result = new int[N];
Random rnd = new Random();
int sum = 0;
Console.Write("Определен массив: ");
for (int i = 0; i < N; i++)
{
    result[i] = rnd.Next(-100, 101); //  диапазон ограничен -100 и 100
    Console.Write(result[i]+" "); 
    if (i % 2 != 0) // 0 четное число
    {
        sum = sum + result[i];     
    }
    
}
Console.Write("\nСумма элементов на нечетных позициях: {0}", sum);
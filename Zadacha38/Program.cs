Console.Clear();
Console.WriteLine("Введите число сколько будет элементов в массиве: ");
int elements_count = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[elements_count];
for(int i = 0; i < elements_count; i++)
{
    numbers[i] = new Random().NextDouble()* 100;
}
double min = numbers.Min();
double max = numbers.Max();
Console.WriteLine($"Массив содержащий числа: {string.Join(", ", numbers)}, минимальное значение равно: {min}, максимальное значение равно: {max}, разница между максимальным и минимальным элементом массива равна: {max - min}");
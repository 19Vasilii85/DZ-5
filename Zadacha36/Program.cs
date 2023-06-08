Console.Clear();
Console.WriteLine("Введите число сколько будет элементов в массиве: ");
int elements_count = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[elements_count];

for(int i = 0; i < elements_count; i++)
{
    numbers[i] = new Random().Next(-100,100);
}
int sum = 0;
for (int z = 1; z < numbers.Length; z+=2)
{
    sum = sum + numbers[z];
}
Console.WriteLine($"Массив содержащий числа: {string.Join(", ", numbers)}, сумму элементов, стоящих на нечётных позициях равна: {sum}");

Console.Clear();
Console.WriteLine("Введите число сколько будет элементов в массиве: ");
int elements_count = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[elements_count];

for(int i = 0; i < elements_count; i++)
{
    numbers[i] = new Random().Next(100,999);
}
int count_even = 0;
for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] % 2 == 0){
        count_even++;
    }
}
Console.WriteLine($"Массив содержащий числа: {string.Join(", ", numbers)}, из них чётные: {count_even}");

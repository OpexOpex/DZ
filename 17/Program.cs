// Сколько чисел больше 0

int length = ReadInt("Array length");
int min = ReadInt("Min value");
int max = ReadInt("Max value");
int[] array = GetRandomArray(length, min, max);

PrintArray(array);
Console.WriteLine();
Positive(array);

int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine());
}

int[] GetRandomArray(int length, int minValue, int maxValue)
{
	int[] array = new int[length];
	Random random = new Random();

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = random.Next(minValue, maxValue + 1);
	}

	return array;
}

void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]}, ");
	}
}

void Positive(int[] array)
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
      if (array[i]>0)
      {
        count=count+1;
      }
    }
    System.Console.WriteLine($"Количество положительных чисел в заданном массиве = {count}");
}

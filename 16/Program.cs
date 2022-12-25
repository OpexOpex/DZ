// Разница между максимальным и минимальным элементами

int length = ReadInt("Array length");
double[] array = GetRandomArray(length, 2, 100);

PrintArray(array);
Console.WriteLine();
double max = FindMax(array);
double min = FindMin(array);
FindDiff(max, min);


int ReadInt(string argument) 
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine());
}

double[] GetRandomArray(int length, double minValue, double maxValue)
{
	double[] array = new double [length];
	Random random = new Random();

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = minValue + random.NextDouble()*(maxValue - minValue);
	}

	return array;
}

void PrintArray(double[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]}, ");
	}
}

double FindMax(double[] array)
{
	double max = array[0];
	for (int i = 0; i < array.Length; i++)
	if (array[i]>max)
	{
		max = array[i];
	}
	return max;
}

double FindMin(double[] array)
{
	double min = array[0];
	for (int i = 0; i < array.Length; i++)
	if (array[i]<min)
	{
		min = array[i];
	}
	return min;
}

void FindDiff(double max, double min)
{
    double result = max - min;
    System.Console.WriteLine($"Разница между {max} и {min} = {result}");

}
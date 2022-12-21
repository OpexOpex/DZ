Console.WriteLine("Введите число A: ");
int a = int.Parse (Console.ReadLine());
Console.WriteLine("Введите B: ");
int b = int.Parse (Console.ReadLine());
Console.WriteLine("Введите число C: ");
int c = int.Parse (Console.ReadLine());
Console.WriteLine("Введите D: ");
int d = int.Parse (Console.ReadLine());
Console.WriteLine("Введите число E: ");
int e = int.Parse (Console.ReadLine());
Console.WriteLine("Введите F: ");
int f = int.Parse (Console.ReadLine());
Console.WriteLine("Введите число G: ");
int g = int.Parse (Console.ReadLine());
Console.WriteLine("Введите H: ");
int h = int.Parse (Console.ReadLine());
int[] array = {a, b, c, d, e, f, g, h};
string ArrayToString(int[] array)
{
	string result ="";

	for (int i = 0; i < array.Length; i++)
	{
		result += $"{array[i]}, ";
	}

	return result;
}

Console.WriteLine(ArrayToString(array));
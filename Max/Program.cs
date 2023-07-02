// See https://aka.ms/new-console-template for more information

Console.Write("Введите размер массива : ");
var size = Convert.ToInt32(Console.ReadLine());
var arr = new List<int>();
var random = new Random();
for (int i = 0; i < size; i++)
{
    arr.Add(random.Next(-10,10));
}

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("[ ");
foreach (var item in arr)
{
    Console.Write($"{item} ");
}
Console.WriteLine("]");
Console.ForegroundColor = ConsoleColor.Yellow;
var max = arr[0];
foreach (var item in arr)
{
    if (item > max)
    {
        max = item;
    }
}
Console.Write($"MAX = {max}");
Console.ResetColor();
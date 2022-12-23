Console.Write("Введите элементы массива через пробел: ");
string? inputString = Console.ReadLine();
string[] inputArray = inputString.Split(' ');

PrintStringArrayInSquares(inputArray);

void PrintStringArrayInSquares(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"\"{array[i]}\", ");
    }
    Console.WriteLine($"\"{array[array.Length - 1]}\"]");
}
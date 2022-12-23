Console.Write("Введите элементы массива через пробел: ");
string? inputString = Console.ReadLine();
string[] inputArray = inputString.Split(' ');

int elementSize = 3;
string[] outputArray = new string[0];
int j = 0;

for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= elementSize)
    {
        Array.Resize(ref outputArray, outputArray.Length + 1);
        outputArray[j++] = inputArray[i];
    }
}

PrintStringArrayInSquares(inputArray);
Console.Write(" -> ");
PrintStringArrayInSquares(outputArray);
Console.WriteLine();

void PrintStringArrayInSquares(string[] array)
{
    if (array.Length != 0)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write($"\"{array[i]}\", ");
        }
        Console.Write($"\"{array[array.Length - 1]}\"]");
    }
    else
    {
        Console.Write("[]");
    }
}
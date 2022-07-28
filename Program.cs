Console.WriteLine("Введите текст. Для разделения слов используйте пробелы (в том числе, после знаков препинания): ");
string text = Console.ReadLine();
Console.WriteLine("Введите количество символов. Слова с таким или меньшим количеством символов будут выведены на экран: ");
int Characters = int.Parse(Console.ReadLine());

string[] CreateArray(string N)
{
    string[] array = N.Split(' ');

    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("'");

        Console.Write(array[i] + "'");

        Console.Write(" ");
    }
}

int Counter(string[] array, int Quantity)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= Quantity)
        {
            count++;
        }
    }
    return count;
}

string[] CreateArrayCharacters(string[] array, int Quantity, int size)
{
    string[] ReceivedArray = new string[size];
    int n = 0;
    for (int m = 0; m < array.Length; m++)
    {
        if (array[m].Length <= Quantity)
        {
            ReceivedArray[n] = array[m];
            n++;
        }
    }
    return ReceivedArray;
}

CreateArray(text);
PrintArray(CreateArray(text));
Console.Write("--> ");
int count = Counter(CreateArray(text), Characters);
CreateArrayCharacters(CreateArray(text), Characters, count);
PrintArray(CreateArrayCharacters(CreateArray(text), Characters, count));
Console.WriteLine();
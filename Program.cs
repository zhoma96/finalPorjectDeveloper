string[] GenerateArray(int n)
{
    string[] Array1 = new string[n];
    int numEl = 1;
    for (int i = 0; i < Array1.Length; i++)
    {
        Console.Write($"Please enter element {numEl}: ");
        Array1[i] = Console.ReadLine();
        numEl++;
    }
    return Array1;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

string[] ArrayThreeSymbols(string[] OrigArray)
{
    string[] NewArray = new string[OrigArray.Length];
    int sizeOFNewArray = 0;
    for (int i = 0; i < OrigArray.Length; i++)
    {
        if (OrigArray[i].Length <= 3)
        {
            NewArray[sizeOFNewArray] = OrigArray[i];
            sizeOFNewArray++;
        }
    }
    return NewArray;
}

int n = 5;
string[] FirstArray = GenerateArray(n);
PrintArray(FirstArray);
Console.WriteLine();
string[] ArrayFinal = ArrayThreeSymbols(FirstArray);
PrintArray(ArrayFinal); 

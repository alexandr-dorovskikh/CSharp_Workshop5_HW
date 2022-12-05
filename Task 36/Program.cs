void FillRandomValuesInArray(ref int[] NumsArray)
{
    for (int i = 0; i < NumsArray.GetLength(0); i++)
    {
        NumsArray[i] = new Random().Next(-100, 101);
    }    
    
}

int GetSumOfOddIndexes(int[] NumsArray)
{
    int Result = 0;

    for (int i = 1; i < NumsArray.GetLength(0); i = i + 2)
    {
        Result += NumsArray[i];
    }

    return Result;        
}

void PrintArray(int[] NumsArray)
{
    int ArraySize = NumsArray.Length;
    
    Console.Write("[");
    
    for (int i = 0; i < ArraySize; i++)
    {
        Console.Write(NumsArray[i]);
        if (i < ArraySize - 1) Console.Write(", ");
    }
    
    Console.Write("]");
}

int SIZE = 8;

int[] NumsArray = new int[SIZE];

FillRandomValuesInArray(ref NumsArray);
PrintArray(NumsArray);

Console.WriteLine();

Console.WriteLine($"Sum of nums on odd indexes: {GetSumOfOddIndexes(NumsArray)}");

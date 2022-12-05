void FillRandomValuesInArray(ref int[] NumsArray)
{
    for (int i = 0; i < NumsArray.GetLength(0); i++)
    {
        NumsArray[i] = new Random().Next(100, 1000);
    }    
    
}

int GetEvenNumsCount(int[] NumsArray)
{
    int Result = 0;

    for (int i = 0; i < NumsArray.GetLength(0); i++)
    {
        if (NumsArray[i] % 2 == 0) Result++;
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

Console.WriteLine($"Count of even numbers in the array: {GetEvenNumsCount(NumsArray)}");

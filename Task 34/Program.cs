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

    foreach (int num in NumsArray)
    {
        if (num % 2 == 0) Result++;
    }

    return Result;        
}

void PrintArray(int[] NumsArray)
{
    Console.Write($"[{string.Join(", ", NumsArray)}]");
}

int SIZE = 8;

int[] NumsArray = new int[SIZE];

FillRandomValuesInArray(ref NumsArray);
PrintArray(NumsArray);

Console.WriteLine();

Console.WriteLine($"Count of even numbers in the array: {GetEvenNumsCount(NumsArray)}");

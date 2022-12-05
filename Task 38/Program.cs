void FillRandomValuesInArray(ref double[] NumsArray)
{
    for (int i = 0; i < NumsArray.GetLength(0); i++)
    {
        NumsArray[i] = new Random().NextDouble() + new Random().Next(0, 100);
    }    
    
}

double DiffOfMinAndMaxNums(double[] NumsArray)
{
    return NumsArray.Max() - NumsArray.Min();          
}

void PrintArray(double[] NumsArray)
{
    Console.Write($"[{string.Join(", ", NumsArray)}]");
}

int SIZE = 8;

double[] NumsArray = new double[SIZE];

FillRandomValuesInArray(ref NumsArray);
PrintArray(NumsArray);

Console.WriteLine();

Console.WriteLine($"Diff of max & min nums in the array: {DiffOfMinAndMaxNums(NumsArray)}");

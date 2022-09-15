// Контрольная работа первого блока

Console.WriteLine("Введите количество элементов строкового массива:");
int arraySize = Convert.ToInt32(Console.ReadLine());
string [] arrayOfString = new string [arraySize];
int elementSize = 4;

void FillArray(string [] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Console.WriteLine($"Введите {i+1}-й элемент строкового массива:");
        Arr[i] = Console.ReadLine();
        Console.Clear();
    }
}

int DefineNewArraySize(string [] Arr)
{
    int newArraySize = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i].Length < elementSize) newArraySize++;
    }
    return newArraySize;
}

void FillNewArray(string [] OldArr, string [] NewArr)
{
    int count = 0;
    for (int i = 0; i < OldArr.Length; i++)
    {
        if (OldArr[i].Length < elementSize)
        {
            NewArr[count] = OldArr[i];
            count++;
        }
    }
}

void PrintArray(string [] Arr)
{
    Console.WriteLine("[" + string.Join(", ", Arr) + "]");    
} 


FillArray(arrayOfString);
string [] resultArray = new string [DefineNewArraySize(arrayOfString)];
FillNewArray(arrayOfString,resultArray);
PrintArray(arrayOfString);
PrintArray(resultArray);
string[] arrayOne = new string[6] {"59684", "777", "hello", "world", "-2", ":-)"};
string[] arrayTwo = new string[arrayOne.Length];
void SecondArrayWithIF(string[] arrayOne, string[] arrayTwo)
{
    int count = 0;
    for (int i = 0; i < arrayOne.Length; i++)
    {
        if(arrayOne[i].Length <= 3)
        {
            arrayTwo[count] = arrayOne[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(arrayOne, arrayTwo);
PrintArray(arrayTwo);
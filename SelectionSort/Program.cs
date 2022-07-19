Console.WriteLine("Selection Sort");
int[] arrayNumber = new int[10] { 7, 4, 3, 6, 2, 9, 1, 5, 8, 0 };

for (int i = 0; i < arrayNumber.Length - 1; i++)
{
    int aux = i;
    for (int j = i; j < arrayNumber.Length; j++)
    {
        if (arrayNumber[j] < arrayNumber[aux])
            aux = j;

        int temp = arrayNumber[aux];
        arrayNumber[aux] = arrayNumber[i];
        arrayNumber[i] = temp;
    }
}

for (int i = 0; i < arrayNumber.Length; i++)
{
    Console.Write(arrayNumber[i] + " ");
}
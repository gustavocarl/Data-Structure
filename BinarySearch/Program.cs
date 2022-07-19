Console.WriteLine("Binary Search\n");

int low = 0, attempt = 0, kick, middle;

Console.WriteLine("Informe o tamanho da lista");
int listLength = int.Parse(Console.ReadLine());

int[] list = new int[listLength + 1];

Console.WriteLine("Informe o elemento que deve ser encontrado na lista");
int searchedElement = int.Parse(Console.ReadLine());

int high = list.Length - 1;

for (int i = 1; i <= list.Length - 1; i++)
{
    list[i] += i;
}

Console.WriteLine($"\n{searchedElement} elemento que deve ser encontrado\n");

do
{
    attempt++;
    middle = (low + high) / 2;
    kick = list[middle];

    if (kick < searchedElement)
        low = middle + 1;
    else if (kick > searchedElement)
        high = middle - 1;

    Console.WriteLine($"{attempt}ª Tentativa: {middle}");
} while (middle != searchedElement);
Console.ReadLine();
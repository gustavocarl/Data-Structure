string[,] names = new string[3, 3];
MainMenu();

void MainMenu()
{
    Console.Clear();
    Console.WriteLine("================================================");
    Console.WriteLine("Estudos de Array");
    Console.WriteLine("================================================");
    Console.WriteLine("Menu Principal");
    Console.WriteLine("================================================");
    Console.WriteLine("1 - Inserir os nome da matriz:");
    Console.WriteLine("2 - Imprimir os nomes da matriz:");
    Console.WriteLine("3 - Imprimir os nomes de uma determinada linha:");
    Console.WriteLine("4 - Imprimir os nomes de uma determinada coluna:");
    Console.WriteLine("5 - Procurar um nome:");
    Console.WriteLine("6 - Ordenar os nomes dentro de cada linha:");
    Console.WriteLine("================================================");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("================================================");
    string option = Console.ReadLine()!;
    switch (option)
    {
        case "0":
            break;

        case "1":
            InsertNamesInArray();
            Console.ReadLine();
            MainMenu();
            break;

        case "2":
            PrintNamesInArray();
            Console.ReadLine();
            MainMenu();
            break;

        case "3":
            PrintNamesInARow();
            Console.ReadLine();
            MainMenu();
            break;

        case "4":
            PrintNamesInAColumn();
            Console.ReadLine();
            MainMenu();
            break;

        case "5":
            SearchNamesInArray();
            Console.ReadLine();
            MainMenu();
            break;

        case "6":
            OrderNamesInArray();
            Console.ReadLine();
            MainMenu();
            break;

        default:
            Console.WriteLine("Opção inválida!");
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
            break;
    }
}

void InsertNamesInArray()
{
    for (int i = 0; i < names.GetLength(0); i++)
    {
        for (int j = 0; j < names.GetLength(1); j++)
        {
            Console.WriteLine("Inserindo nomes no array: ");
            Console.WriteLine($"Você está inserindo um nome na linha {i + 1} e coluna {j + 1}");
            names[i, j] = Console.ReadLine()!;
        }
    }
}

void PrintNamesInArray()
{
    Console.WriteLine("Os nomes inseridos no array são: ");
    for (int i = 0; i < names.GetLength(0); i++)
    {
        for (int j = 0; j < names.GetLength(1); j++)
        {
            Console.Write($"{names[i, j]}    ");
        }
        Console.WriteLine();
    }
}

void PrintNamesInARow()
{
    int row;
    do
    {
        Console.WriteLine("Qual linha deseja imprimir: ");
        row = int.Parse(Console.ReadLine()!);
    } while (row < 1 || row > names.GetLength(0));

    for (var i = 0; i < names.GetLength(1); i++)
    {
        Console.WriteLine(names[row - 1, i]);
    }
}

void PrintNamesInAColumn()
{
    int column;
    do
    {
        Console.WriteLine("Qual coluna deseja imprimir: ");
        column = int.Parse(Console.ReadLine()!);
    } while (column < 1 || column > names.GetLength(1));

    for (var i = 0; i < names.GetLength(0); i++)
    {
        Console.WriteLine(names[i, column - 1]);
    }
}

void SearchNamesInArray()
{
    Console.WriteLine("Qual nome deseja buscar no array: ");
    string name = Console.ReadLine()!;
    bool nameFounded = false;

    for (var i = 0; i < names.GetLength(0); i++)
    {
        for (var j = 0; j < names.GetLength(1); i++)
        {
            if (name.Equals(names[i, j]))
            {
                Console.WriteLine($"O nome {name} foi encontrado na linha {i + 1} e na coluna {j + 1}");
                nameFounded = true;
                break;
            }
        }
        if (nameFounded)
            break;
    }

    if (!nameFounded)
        Console.WriteLine($"O nome {name} não foi encontrado no array.");
}

void OrderNamesInArray()
{
    StringComparer order = StringComparer.OrdinalIgnoreCase;
    int row;

    do
    {
        Console.WriteLine("Qual linha deseja imprimir: ");
        row = int.Parse(Console.ReadLine()!);
    } while (row < 0 || row > names.GetLength(0));

    for (int column = 0; column < names.GetLength(1); column++)
    {
        for (int aux = column + 1; aux < names.GetLength(1); aux++)
        {
            if (order.Compare(names[row, aux], names[row, column]) < 0)
            {
                string temp = names[row, aux];
                names[row, aux] = names[row, column];
                names[row, column] = temp;
            }
        }
    }

    PrintNamesInArray();
}

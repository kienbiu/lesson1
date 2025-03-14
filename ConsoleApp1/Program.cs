// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//{
//    int dem = 0;
//    Console.WriteLine("Danh sach so nguyen to :");
//    for (int i = 2; i <= 100; i++)
//    {
//        for (int j = 1; j <= i; j++)
//        {
//            if (i % j == 0)
//            {
//                dem++;
//            }
//        }

//        if (dem == 2)
//        {
//            Console.WriteLine(i);
//        }
//        dem = 0;
//    }
//}

bool exit = false;
while (!exit)
{
    Console.WriteLine("Menu");
    Console.WriteLine("1. Print the rectangle");
    Console.WriteLine("2. Print the square triangle");
    Console.WriteLine("3. Print isosceles triangle");
    Console.WriteLine("4. Exit");
    Console.Write("Choose an option: ");

    string? strInput = Console.ReadLine();
    string strIn = strInput ?? string.Empty;
    int.TryParse(strIn, out int choice);

    switch (choice)
    {
        case 1:
            PrintRectangle();
            break;
        case 2:
            PrintSquareTriangle();
            break;
        case 3:
            PrintIsoscelesTriangle();
            break;
        case 4:
            exit = true;
            break;
        default:
            Console.WriteLine("Please try again.");
            break;
    }
}

void PrintRectangle()
{
    Console.WriteLine("Enter width: ");
    int width = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Enter height: ");
    int height = int.Parse(Console.ReadLine() ?? "0");

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

void PrintSquareTriangle()
{
    Console.WriteLine("Choose the corner (1: top-left, 2: top-right, 3: bottom-left, 4: bottom-right): ");
    int corner = int.Parse(Console.ReadLine() ?? "0");

    switch (corner)
    {
        case 1:
            for (int i = 5; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            break;
        case 2:
            for (int i = 5; i > 0; i--)
            {
                for (int j = 0; j < 5 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            break;
        case 3:
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            break;
        case 4:
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < 5 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            break;
        default:
            Console.WriteLine("Invalid corner choice.");
            break;
    }
}

void PrintIsoscelesTriangle()
{
    Console.WriteLine("Enter the height: ");
    int height = int.Parse(Console.ReadLine() ?? "0");

    for (int i = 1; i <= height; i++)
    {
        for (int j = 0; j < height - i; j++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j < 2 * i - 1; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

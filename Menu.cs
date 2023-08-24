namespace EditorHTML;

public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Yellow;

        DrawScreen();
        WriteMenuOptions();

        short option = short.Parse(Console.ReadLine()!);

        HandleMenuOptions(option);

    }

    public static void DrawScreen()
    {
        DrawRows("+", "-", 40, 1, false, false);
        DrawRows("|", " ", 40, 11, true, true);
        DrawRows("+", "-", 40, 1, false, false);
    }

    public static void DrawRows(string limitCharacter, string colunmCharacter, int width, int height, Boolean newLineAbove, Boolean newLineUnder)
    {
        for (int x = 0; x < height; x++)
        {
            if (newLineAbove && x == 0) Console.WriteLine("");
            Console.Write(limitCharacter);
            for (int i = 0; i < width; i++) Console.Write(colunmCharacter);
            Console.Write(limitCharacter);
            if (newLineUnder) Console.WriteLine("");
        }

    }

    public static void WriteMenuOptions()
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Editor HTML");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("============");
        Console.SetCursorPosition(3, 5);
        Console.WriteLine("Selecione uma opção abaixo:");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("1 - Novo arquivo");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("2 - Abrir");
        Console.SetCursorPosition(3, 9);
        Console.WriteLine("0 - Sair");
        Console.SetCursorPosition(3, 10);
        Console.Write("Opção: ");
    }

    public static void HandleMenuOptions(short option)
    {
        switch (option)
        {
            case 1: Editor.Show(); break;
            case 2: Open(); break;
            case 0: Console.Clear(); Environment.Exit(0); break;
            default: Show(); break;
        }
    }

    public static void Open()
    {
        Console.Clear();

        Console.WriteLine("open");
    }
}


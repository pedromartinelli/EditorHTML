namespace EditorHTML;

public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Yellow;

        DrawScreen();
    }

    public static void DrawScreen()
    {
        DrawRows("+", "-", 30, 1, false, false);
        DrawRows("|", " ", 30, 20, true, true);
        DrawRows("+", "-", 30, 1, false, false);
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
}


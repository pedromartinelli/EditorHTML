using System.Text;

namespace EditorHTML
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");
            Edit();
        }

        public static void Edit()
        {
            var file = new StringBuilder();

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine(" Deseja salvar o arquivo? S/N");
            Console.ReadKey();

            Viewer.Show(file.ToString());
        }
    }
}

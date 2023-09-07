namespace Class_Library.Menus;

public class For_All_Menu
{
    public static void print_menu(string[] menu_choices, int select_choice, string message)
    {
        Console.WriteLine(message);
        Console.WriteLine();
        for (int i = 0; i < menu_choices.Length; i++)
        {
            if (i == select_choice)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(">> ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("   ");
            }
            Console.WriteLine(menu_choices[i]);
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nPress Enter to select operation or Esc to exit.");
    }
}
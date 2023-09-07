namespace Class_Library.Menus;

internal class Menu_for_exchange
{
    public static void Main(Client current_client)
    {
        string[] menu_choices = { "Dollar", "Manat", "Ruble", "Euro" };
        int select_choice = 0;
        bool menu_check = true;

        while (menu_check)
        {
            Console.Clear();
            For_All_Menu.print_menu(menu_choices, select_choice, "Show My Balance With: ");

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    select_choice = (select_choice - 1 + menu_choices.Length) % menu_choices.Length;
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    select_choice = (select_choice + 1) % menu_choices.Length;
                    break;
                case ConsoleKey.Enter:
                    start_operation(menu_choices[select_choice], current_client);
                    Thread.Sleep(4000);
                    break;
                case ConsoleKey.Escape:
                    menu_check = false;
                    break;
            }
        }
    }

    static void start_operation(string select_choice, Client current_client)
    {
        Console.Clear();
        switch (select_choice)
        {
            case "Dollar":
                Console.WriteLine($"Your Current Balance: {current_client.bank_Card.Balance} Dollar");
                Thread.Sleep(3000);
                Main(current_client);
                break;
            case "Manat":
                Console.WriteLine($"Your Current Balance: {current_client.bank_Card.Balance * 1.7} Manat");
                Thread.Sleep(3000);
                Main(current_client);
                break;
            case "Ruble":
                Console.WriteLine($"Your Current Balance: {current_client.bank_Card.Balance * 98.3} Ruble");
                Thread.Sleep(3000);
                Main(current_client);
                break;
            case "Euro":
                Console.WriteLine($"Your Current Balance: {current_client.bank_Card.Balance / 0.93} Euro");
                Thread.Sleep(3000);
                Main(current_client);
                break;
        }
    }
}
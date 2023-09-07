using Class_Library.About_Bank;
namespace Class_Library.Menus;

public class First_Menu
{
    public static void Main(Bank bank, Client current_client)
    {
        string[] menu_choices = { "See Current Balance", "Cash", "Card To Card", "List of Transactions", "About Me" };
        int select_choice = 0;
        bool menu_check = true;

        while (menu_check)
        {
            Console.Clear();
            For_All_Menu.print_menu(menu_choices, select_choice, "Select An Operation, Please:");

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
                    start_operation(bank,menu_choices[select_choice], current_client);
                    Thread.Sleep(4000);
                    break;
                case ConsoleKey.Escape:
                    menu_check = false;
                    break;
            }
        }
    }

    static void start_operation(Bank bank,string select_choice, Client current_client)
    {
        Console.Clear();
        switch (select_choice)
        {
            case "See Current Balance":
                Menu_for_exchange.Main(current_client);
                break;
            case "Cash":
                try
                {
                    Cash_Menu.Main(current_client);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                break;
            case "Card To Card":
                Console.Write("Enter Tha PAN Of Card That You Want To Send Money To: ");
                string entered_PAN = Console.ReadLine();
                Console.Write("Enter The Amount Of Money: ");
                string? amount= Console.ReadLine();
                try
                {
                    Card_To_Card.card_to_card(bank, current_client, entered_PAN, Convert.ToDouble(amount));
                    Console.Clear();
                    Console.WriteLine("Money Sent Succesfully");
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.ToString());
                }
                break;
            case "List of Transactions":
                Console.Clear();
                current_client.show_all_transactions();
                break;
            case "About Me":
                Console.Clear();
                current_client.about_me();
                break;
        }
    }
}
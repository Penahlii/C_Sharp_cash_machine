namespace Class_Library.Menus;

public class Cash_Menu
{
    private static void check(Client current_client, double cash)
    {
        if (cash <= current_client.bank_Card.Balance && cash > 0)
        {
            Console.Clear();
            current_client.bank_Card.Balance -= cash;
            Transaction_Class new_transaction = new($"WithDrawed Money: {cash}$\nYour Current Balance: {current_client.bank_Card.Balance}");
            current_client.transactions.Add(new_transaction);
            Console.WriteLine($"{cash}$ WithDrawed");
        }
        else
            throw new Exception("Unfortunately, You Do Not Have This Balance In your Current Balance");
    }

    public static void Main(Client current_client)
    {
        string[] menu_choices = { "10$", "20$" ,"50$", "100$", "Other"};
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
            case "10$":
                check(current_client, 10);
                break;
            case "20$":
                check(current_client, 20);
                break;
            case "50$":
                check(current_client, 50);
                break;
            case "100$":
                check(current_client, 100);
                break;
            case "Other":
                Console.Clear();
                Console.Write("Enter Balance: ");
                string? cash = Console.ReadLine();
                check(current_client, Convert.ToInt32(cash));
                break;
        }
        Console.ReadKey(true);
    }
}
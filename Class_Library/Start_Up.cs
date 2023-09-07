using Class_Library.About_Bank;
using Class_Library.Menus;
using ClassLibrary2;

namespace Class_Library;

public class Start_Up
{
    public static void start_up(Bank bank)
    {
        while (true)
        {
            Console.Clear();
            Console.Write("Enter Your Bank Card PIN, Please: ");
            string? PIN = Class1.GetMaskedInput();
            Client current_client;
            try
            {
                current_client = bank.first__(PIN);
                Console.Clear();
                Console.WriteLine($"Welcome {current_client?.Name} {current_client?.Surname}");
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.ToString());
                Thread.Sleep(5000);
                continue;
            }
            First_Menu.Main(bank,current_client);
        }
    }
}
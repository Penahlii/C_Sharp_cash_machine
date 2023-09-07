using Class_Library.About_Bank;

namespace Class_Library;

public class Card_To_Card
{
    public static void card_to_card(Bank bank, Client current_client, string PAN, double amount)
    {
        if (current_client.bank_Card.Balance < amount)
            throw new Exception("Your Balance Is Not Enough For The Money Transfer");
        foreach (var client in bank.clients)
        {
            if (client.bank_Card.PAN == PAN)
            {
                current_client.bank_Card.Balance -= amount;
                client.bank_Card.Balance += amount;
                Transaction_Class new_transaction_for_current_client = new($"From: You\nTo: {PAN}\nBalance -= {amount}\nYour Current Balance: {current_client.bank_Card.Balance}");
                Transaction_Class new_transaction_for_PAN = new($"From: {current_client.bank_Card.PAN}\nTo: You\nBalance += {amount}\nYour Current Balance: {client.bank_Card.Balance}");
                current_client.transactions.Add(new_transaction_for_current_client);
                client.transactions.Add(new_transaction_for_PAN);
                return;
            }
        }
        throw new Exception("PAN Does Not Exist");
    }
}
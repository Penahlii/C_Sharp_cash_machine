using ClassLibrary2;

namespace Class_Library.About_Bank;

public class Bank
{
    public List<Client> clients;

    //////////////////////////////////////////

    public Client first__(string PIN)
    {
        foreach(var client in this.clients)
        {
            if (client.bank_Card.PIN == PIN)
                return client;
        }
        throw new Exception("PIN Does not Exist");
    }

    public void add_client(Client new_client)
    {
        foreach (var client in this.clients)
        {
            if (client.bank_Card.PAN == new_client.bank_Card.PAN || client.bank_Card.PIN == new_client.bank_Card.PIN || client.bank_Card.CVC == new_client.bank_Card.CVC)
                throw new Exception("CVC, PAN or PIN Exists Try New One");
        }
        this.clients.Add(new_client);
    }

    // Constructors

    public Bank() { this.clients = new List<Client>(); }

}
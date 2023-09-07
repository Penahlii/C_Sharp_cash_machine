using Class_Library.About_Bank;

using Class_Library;
using System.Collections.Specialized;

Bank a = new();



try
{
    a.add_client(new Client("Ibrahim", "Penahli", 16, 500000, new Bank_Card(Banks.Kapital_Bank, "Penahli Ibrahim", "1234567890123456", "1234", "123", 1000)));
    a.add_client(new Client("Orxan", "Memmedli", 16, 500000, new Bank_Card(Banks.Bank_of_Baku, "Orxan Meemedli", "1234556789012345", "4321", "321", 1000)));
    a.add_client(new Client("Ibrahim", "Alizade", 16, 500000, new Bank_Card(Banks.UniBank, "Ibrahim Alizade", "1234512389012378", "9999", "990", 1000)));
    a.add_client(new Client("Ruslan", "Eyyubov", 21, 500000, new Bank_Card(Banks.Bank_Respublika, "Ruslan Eyyubov", "0981234123456712", "6576", "121", 1000)));
    a.add_client(new Client("Reshad", "Beshirov", 24, 500000, new Bank_Card(Banks.Pasha_Bank, "Reshad beshirov", "1234567890981237", "9812", "139", 1000)));
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
Start_Up.start_up(a);
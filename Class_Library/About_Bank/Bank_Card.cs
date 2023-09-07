using System.Runtime.InteropServices;
using ClassLibrary2;
namespace Class_Library.About_Bank;


public enum Banks
{
    UniBank,
    Accessbank,
    International_Bank_of_Azerbaijan,
    Bank_of_Baku,
    Bank_Respublika,
    Kapital_Bank,
    Pasha_Bank,
    Yelo_Bank
}

public class Bank_Card
{
    public Banks Bank_Name { get; set; }

    private string full_name;
    public string Full_Name
    {
        get => full_name;
        set
        {
            if (value != null && value.Length >= 3)
                full_name = value;
            else
                throw new InvalidDataException();
        }
    }

    private string pan;

    public string PAN
    {
        get => this.pan;
        set
        {
            if (value.Length == 16)
                this.pan = value;
            else
                throw new InvalidDataException("PAN's Length must be 16");
        }
    }

    private string pin;

    public string PIN
    {
        get => this.pin;
        set
        {
            if (value.Length == 4)
                this.pin = value;
            else
                throw new InvalidDataException("PIN's Length must be 4");
        }
    }

    private string cvc;

    public string CVC
    {
        get => this.cvc;
        set
        {
            if (value.Length == 3)
                this.cvc = value;
            else
                throw new InvalidDataException("CVC's Length must be 3");
        }
    }

    public string Expire_Date;


    public double Balance;

    // Constructors

    public Bank_Card(Banks bank_name, string full_name, string pan, string pin, string cvc,float balance = 0)
    {
        Bank_Name = bank_name;
        Full_Name = full_name;
        this.PAN = pan;
        this.PIN = pin;
        this.CVC = cvc;
        Expire_Date = DateTime.Now.AddYears(3).ToString();
        this.Balance = balance;
    }
}
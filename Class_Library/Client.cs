using Class_Library.About_Bank;
using ClassLibrary2;
namespace Class_Library;

public class Client
{
    public Guid ID;

    private string name;

    public string Name
    {
        get => this.name;
        set
        {
            if (value != null && value.Length >= 3)
                this.name = value;
            else
                throw new InvalidDataException("Name Can Not Be Null Or Lenght Can Not Be Less Than 3");
        }
    }

    private string surname;
    public string Surname
    {
        get => this.surname;
        set
        {
            if (value != null && value.Length >= 3)
                this.surname = value;
            else
                throw new InvalidDataException("SurName Can Not Be Null Or Lenght Can Not Be Less Than 3");
        }
    }

    private byte age;
    public byte Age
    {
        get => this.age;
        set
        {
            if (value >= 1 && value <= 90)
                this.age = value;
            else
                throw new InvalidDataException("Age must be between 1 and 90");
        }
    }

    private float salary;
    public float Salary
    {
        get => this.salary;
        set
        {
            if (value >= 100)
                this.salary = value;
            else
                throw new InvalidDataException("Salary Must Be At Least 100");
        }
    }

    public Bank_Card bank_Card;


    public List<Transaction_Class> transactions;

    public void show_all_transactions()
    {
        if (this.transactions.Count == 0)
            Console.WriteLine("There Is Not Any Transaction Yet");
        foreach(var transaction in transactions)
        {
            Console.WriteLine(transaction);
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    public void about_me()
    {
        Console.WriteLine($"Surname: {this.surname}\nName: {this.name}\nAge: {this.age}\nBank of My Card: {this.bank_Card.Bank_Name}\nCard Balance: {this.bank_Card.Balance}$");
    }

    // Constructors

    public Client(string name, string surname,byte age, float salary, Bank_Card bank_card)
    {
        this.ID = Guid.NewGuid();
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
        this.Salary = salary;
        this.bank_Card = bank_card;
        this.transactions = new List<Transaction_Class>();
    }
}
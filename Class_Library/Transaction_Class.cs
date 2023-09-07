using System.Security.Cryptography.X509Certificates;

namespace Class_Library;

public class Transaction_Class
{
    public string Date_Time;
    public string message;


    public override string ToString()
    {
        string all_text = $"Date: {this.Date_Time}\n{this.message}";
        return all_text;
    }

    // Constructors

    public Transaction_Class(string message)
    {
        this.message = message;
        this.Date_Time = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
    }
}
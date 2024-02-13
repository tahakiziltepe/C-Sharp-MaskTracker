// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Citizen citizen1 = new Citizen();
citizen1.birthYear = DateTime.Now.Year;

public class Citizen
{
    //public string name = "Name1";
    //public string lastName = "Lastname1";
    //public int birthYear = 1985;
    //public long identityNumber = 1234567910;

    public string name { get; set; }
    public string lastName { get; set; }
    public int birthYear { get; set; }
    public long identityNumber { get; set; }
}

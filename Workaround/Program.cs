// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;
using System.Security.Authentication;


Citizen citizen = new Citizen();
citizen.FirstName = "Test";
citizen.LastName = "Test";
citizen.BirthDate = 1998;
citizen.IdentityNumber = 12345678910;

PttManager pttManager = new PttManager(new CitizenManager());
pttManager.GiveMask(citizen);


static void SayHello(string Name = "")
{
    Console.WriteLine("Hello " + Name + "!");
}

SayHello();
SayHello("FirstName");

static int Add(int number1 = 0, int number2 = 0)
{
    int result = number1 + number2;
    Console.WriteLine("Total : " + result);
    return result;
}

int sonuc = Add(2,3);


// Arrays 
string[] students = new string[3];
students[0] = "Student 0";
students[1] = "Student 1";
students[2] = "Student 2";

foreach (string student in students)
{
    Console.WriteLine($"{student}");
}


Vatandas citizen1 = new Vatandas();
citizen1.BirthYear = DateTime.Now.Year;
public class Vatandas
{
    //public string name = "Name1";
    //public string lastName = "Lastname1";
    //public int birthYear = 1985;
    //public long identityNumber = 1234567910;

    public string Name { get; set; }
    public string LastName { get; set; }
    public int BirthYear { get; set; }
    public long IdentityNumber { get; set; }
}


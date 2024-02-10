using Business.Concrete;
using Entities.Concrete;

Person person = new Person();
person.NationalIdentity= 00000;
person.FirstName = "Baha";
person.LastName = "Barut";
person.DateOfBirthYear = 2000;
List<string> sehirler = new List<string> { "Ankara", "Istanbul", "Izmir" };
sehirler.Add("Adana");
foreach (var item in sehirler)
{
    Console.WriteLine(item);
}

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person);
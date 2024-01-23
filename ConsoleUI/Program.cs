using BackEnd.Items;
using BackEnd.services;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IT Aset Management System");

            Asset asset = new Asset();

            PersonService personService = new PersonService();
            personService.AddNewPerson(1,"Kowal");
            personService.AddNewPerson(2, "Nowak");
            personService.AddNewPerson(3, "Janiak");
            personService.AddNewPerson(2, "Janiak");

            personService.AddNewPerson(2, "Janiak");
            personService.AddNewPerson(2, "Janiak");
            personService.AddNewPerson(2, "Janiak");
            personService.AddNewPerson(2, "Janiak");
            personService.AddNewPerson(2, "Janiak");

            personService.DelPerson(2);

            AssetService assetService = new AssetService();
            assetService.AddNewAsset(1, "Laptop HP", "nowy", new DateOnly(2024,1,1),new DateOnly(), "123/24", new DateOnly(2024,1,2), 2300.01);
            assetService.AddNewAsset(2, "Laptop Acer", "nowy", new DateOnly(2024, 1, 1), new DateOnly(), "123/24", new DateOnly(2024, 1, 2), 2300.01);
            assetService.AddNewAsset(3, "iPhone12", "nowy", new DateOnly(2024, 1, 1), new DateOnly(), "123/24", new DateOnly(2024, 1, 2), 2300.01);
            assetService.AddNewAsset(4, "Sams. Galaxy 11", "nowy", new DateOnly(2024, 1, 1), new DateOnly(), "123/24", new DateOnly(2024, 1, 2), 2300.01);
            assetService.AddNewAsset(5, "Tablet", "jakiś", new DateOnly(2024, 1, 1), new DateOnly(), "123/24", new DateOnly(2024, 1, 2), 2300.01);

            List<Person> result = personService.GetAllPersons();
            Console.WriteLine("**********************");
            foreach (Person person in result)
            {
                Console.WriteLine($"to jest linia {person.Name} {person.Id}");
            }

            List<Asset> resultAsset = assetService.GetAllAssets();
            Console.WriteLine("-------------------------");
            foreach (Asset ass in resultAsset)
            {
                Console.WriteLine($"to jest sprzęt: {ass.Name} cena: {ass.Value}");
            }

            Console.ReadLine();
        }
    }
}

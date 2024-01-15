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
            personService.AddNewPerson();
            List<Person> result = personService.GetAllPersons();

            foreach (Person ps in result)
            {
                Console.WriteLine($"to jest linia {ps.Name}");
            }

        }
    }
}

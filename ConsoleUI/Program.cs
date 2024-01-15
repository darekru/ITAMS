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

            List<Person> result = personService.GetAllPersons();

            foreach (Person person in result)
            {
                Console.WriteLine($"to jest linia {person.Name} {person.Id}");
            }

        }
    }
}

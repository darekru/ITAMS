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
            PersonService result = personService.GetAllPersons();

            foreach (PersonService ps in result)
            {

            }

        }
    }
}

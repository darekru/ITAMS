using BackEnd.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BackEnd.services
{
    public class PersonService
    {

        public List<Person> personsList;

        public PersonService()
        {
            List<Person> personsList = new List<Person>();
            this.personsList = personsList;
        }

        public List<Person> GetAllPersons()
        {
            return personsList;
        }

        public int AddNewPerson()
        {
            Person person = new Person();
            person.Id = 1;
            person.Name = "Test";

            personsList.Add(person);

            person.Id = 2;
            person.Name = "Test2";

            personsList.Add(person);

            return person.Id;
        }

    }
}

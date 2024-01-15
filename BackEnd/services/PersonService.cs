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

        private List<Person> personsList;

        public PersonService()
        {
            List<Person> personsList1 = new List<Person>();
            personsList = personsList1;
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

            Person person1 = new Person();
            person1.Id = 2;
            person1.Name = "Test2";

            personsList.Add(person1);

            return person.Id;
        }

    }
}

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

        public int AddNewPerson(int ID, string NAME)
        {
            Person person = new Person();
            person.Id = ID;
            person.Name = NAME;

            personsList.Add(person);

            return person.Id;
        }

    }
}

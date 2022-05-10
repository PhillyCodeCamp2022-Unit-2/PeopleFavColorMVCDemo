using MVCDemoThing.Models;
using System.Collections.Generic;

namespace MVCDemoThing.Data
{
    public static class PersonData
    {
        // This people still be the container for Person objects in our application
        // We make it static so that we don't have to create an instance of this
        // PersonData class
        public static List<Person> people = new List<Person>();

        // Let's design an Add method specifically for adding Person objects into this people
        // list. That way, we can invoke PersonData.Add and pass in a new person object to be stored
        public static void Add(Person personObject)
        {
            people.Add(personObject);
        }
    }
}

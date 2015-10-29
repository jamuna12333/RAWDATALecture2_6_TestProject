using System.Xml;

namespace Dependencies
{
    public class Repository
    {
        private readonly string _connectionString;
        Database _database;

        public Repository(string connectionString)
        {
            _database = new Database(connectionString);
        }

        public PersonModel GetPersonById(int id)
        {
            var person = _database.FindPerson(id);

            return new PersonModel
            {
                Name = person.Name,
                Age = person.Age
            };
        } 
    }
}
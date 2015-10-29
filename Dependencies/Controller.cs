using System.Collections.Generic;

namespace Dependencies
{
    public class Controller
    {
        private string _connectionString = "helloDb";
        Repository _repository;

        public Controller()
        {
            _repository = new Repository(_connectionString);
        }

        public PersonModel GetPerson(int id)
        {
            var person = _repository.GetPersonById(id);

            return person;
        } 
    }
}
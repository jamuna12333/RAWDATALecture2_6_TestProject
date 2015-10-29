using System.Collections.Generic;
using Newtonsoft.Json;

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

        public string GetPerson(int id)
        {
            var person = _repository.GetPersonById(id);

            return JsonConvert.SerializeObject(person);
        } 
    }
}
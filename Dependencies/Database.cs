using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencies
{
    public class Database
    {
        private readonly string _connectionString;

        public Database(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Person FindPerson(int id)
        {
            return new Person
            {
                Id = id,
                Name = "Peter",
                Age = 22
            };
        }
    }
}

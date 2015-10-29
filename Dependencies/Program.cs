using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencies
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new Controller();
            var person = controller.GetPerson(1);

            Console.WriteLine(person);
        }
    }
}

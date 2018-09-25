using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideColumnExample
{
    public class Person
    {
        public Person(int id, string name, string location)
        {
            Id = id;
            Name = name;
            Location = location;
        }

        public Person()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}

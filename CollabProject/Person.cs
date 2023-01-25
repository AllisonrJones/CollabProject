using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollabProject
{
    public class Person
    {
        //properties
        public string Name { get; set; }
        public int Age { get; set; }

        //constructor
        public Person(string _name, int _Age)
        {
            Name = _name;
            Age = _Age;
        }
    }
}

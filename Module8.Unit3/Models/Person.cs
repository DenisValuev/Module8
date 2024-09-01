using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Module8.Unit3.Models
{
    [Serializable]
    internal class Person
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public Person(string name, int year)
        {
            Name = name;
            Year = year;
        }
    }
}

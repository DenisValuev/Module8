using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Module8.Unit3.Models
{
    [Serializable]
    internal class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Pet(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}

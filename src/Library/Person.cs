using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person
    {
        public int Age;
        public string Name;
        public Person(string name, int age)
        {
           this.Name = name;
           this.Age = age;
        }

    }
}

using System;
using System.Reflection;

namespace PropertyInfoSetValueApplication
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Keone";
            Console.WriteLine(person.Name);
            Type personType = person.GetType();
            PropertyInfo nameProp = personType.GetProperty("Name");
            nameProp.SetValue(person, "Courage");
            Console.WriteLine(person.Name);
        }
    }
}
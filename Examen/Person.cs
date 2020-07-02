using System;
namespace Examen
{
    public class Person
    {
        private string name;
        private int age;
        private string nationality;
        private int salary;

        public Person(string name, int age, string nationality, int salary)
        {
            this.name = name;
            this.age = age;
            this.nationality = nationality;
            this.salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public int Salary { get => salary; set => salary = value; }
    }
}

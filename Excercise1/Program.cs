using System;
using System.Collections.Generic;

namespace CreateClass
{
    class Program
    {
        public enum Gender { Male, Female }
        public class Person
        {
            private String name;
            private DateTime birthDate;
            private Gender gender;

            public Person(string name, DateTime birthDate, Gender gender)
            {
                this.name = name;
                this.birthDate = birthDate;
                this.gender = gender;
            }

            public string Name { get => name; set => name = value; }
            public DateTime BirthDate { get => birthDate; set => birthDate = value; }
            internal Gender Gender { get => gender; set => gender = value; }

            public override string ToString()
            {
                return "Person name is: " + name + "\nbirthdate: " + birthDate + "\ngender: " + gender;
            }
        }
        static void Main(string[] args)
        {
            var jack = new Person("Jack", new DateTime(1982, 3, 11), Gender.Male);
            var pali = new Person("Pali", new DateTime(1975, 12, 14), Gender.Male);
            var robi = new Person("Robi", new DateTime(2000, 3, 22), Gender.Male);
            var kati = new Person("Kati", new DateTime(1976, 6, 1), Gender.Female);

            List<Person> personList = new List<Person>();
            personList.Add(jack);
            personList.Add(pali);
            personList.Add(robi);
            personList.Add(kati);

            foreach (Person person in personList)
            {
                Console.WriteLine(person);
                Console.WriteLine();
            }

            Console.ReadKey(true);
        }
    }
}

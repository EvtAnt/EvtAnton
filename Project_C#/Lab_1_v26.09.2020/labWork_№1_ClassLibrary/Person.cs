using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labWork__1_ClassLibrary
{
    public class Person
    {
        private string surname;
        private string name;
        private int age;
        private Gender gender;
        public Person(string Surname, string Name, int Age, Gender gen)
        { surname = Surname; name = Name; age = Age; gender = gen; }
    }
}

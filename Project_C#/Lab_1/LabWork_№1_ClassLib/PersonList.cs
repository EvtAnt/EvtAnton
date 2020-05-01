using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork__1_ClassLib
{
    public class PersonList
    {
        private Person[] _person;

        public void addPerson(Person person)
        {
            var buff = _person; // создаём дубликат для дальнейшего переопределения _person

            _person = new Person[buff.Length + 1]; // для переопределения длины массива Person
            for(int i = 0; buff.Length < i; i++)
            {
                _person[i] = buff[i];
            }
            _person[buff.Length + 1] = person;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        private string Name;
        private string Surname;
        private DateTime DateOfBirth;
        public Person(string _name, string _surname, DateTime _data)
        {
            Name = _name;
            Surname = _surname;
            DateOfBirth = _data;
        }
        public Person()
        {
            Name = "NoName";
            Surname = "Nobody";
            DateOfBirth = new DateTime(2000, 01, 01);
        }
        public string _name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string _surname
        {
            get { return Surname; }
            set { Surname = value; }
        }
        public DateTime _dateOfBirth
        {
            get { return DateOfBirth; }
            set { DateOfBirth = value; }
        }
        public int _year
        {
            get { return this.DateOfBirth.Year; }
            set { DateOfBirth = new DateTime(value, DateOfBirth.Month, DateOfBirth.Day); }
        }
        public override string ToString()
        {
            return $"Name: {Name} Surname: {Surname} Date_of_Birth: {DateOfBirth}";
        }
        public virtual string ToShortString()
        {
            return $"Name: {Name} Surname: {Surname}";
        }
    }
}

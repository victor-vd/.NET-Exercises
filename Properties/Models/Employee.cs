using System;

namespace Models.Employee
{
    public class Employee
    {
        private string _name;
        public string Name
        {
            get => this._name;

            set
            {
                this._name = value;
            }
        }
        private int _age;
        public int Age
        {
            get => this._age;

            set
            {
                this._age = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}";
        }
    }
}
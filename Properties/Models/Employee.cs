using System;

namespace Models.Employee
{
    public class Employee
    {
        private string _nome;
        public string Name
        {
            get => this._nome;

            set
            {
                this._nome = value;
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
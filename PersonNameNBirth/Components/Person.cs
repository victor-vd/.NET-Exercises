using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.Components
{
    public class Person
    {

        DateTime now = DateTime.Now;
        public int[] currentDate = new int[3];
        public string name { get; set; }
        public int age { get; set; }
        public string birthday { get; set; }
        public int[] birthdayArr = new int[3];

        public Person(string personName, string personBirthday)
        {
            currentDate = [now.Year, now.Month, now.Day];
            name = personName;
            birthday = personBirthday;
            birthdayArr = Array.ConvertAll(personBirthday.Split("/"), s => int.Parse(s));
            age = now.Year - birthdayArr[0];
            if (now.Year >= birthdayArr[0] && now.Month >= birthdayArr[1] && now.Day >= birthdayArr[2])
            {
                age++;
            }
        }

        public void Print()
        {
            Console.WriteLine($"\n Age: {age} \n Name: {name}" +
            $"\n Birthday: {birthday}");
        }
    }
}
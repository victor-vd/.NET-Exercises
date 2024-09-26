using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientLogin.Components
{
    public class Client
    {

        DateTime now = DateTime.Now;
        public int[] currentDate = new int[3];
        private string name { get; set; }
        private uint age { get; set; }
        private string birthday { get; set; }
        private string email { get; set; }
        private string password { get; set; }
        private int[] birthdayArr = new int[3];

        public Client()
        {
            currentDate = [now.Year, now.Month, now.Day];
            name = "";
            age = 0;
            birthday = "";
            email = "";
            password = "";
        }
        public void Check()
        {
            //  This is called interpolation
            Console.WriteLine($"\nName: {name}\nAge: {age}\nBirthday: {birthday}\nEmail: {email}\nPassword: {password}\n");
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 100)
                {
                    name = value;
                }
            }
        }
        public uint Age
        {
            get { return age; }
        }
        public string Birthday
        {
            get { return birthday; }
            set
            {
                birthday = value;
                birthdayArr = Array.ConvertAll(birthday.Split("/"), int.Parse);
                age = (uint)(now.Year - birthdayArr[0]);
                if (now.Year >= birthdayArr[0] && now.Month >= birthdayArr[1] && now.Day >= birthdayArr[2])
                {
                    age++;
                }
            }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length < 40)
                {
                    password = value;
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logics
{
    class User
    {
        DateTime birthDate;
        string surname, name, patronymic,passport,email;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }

        public User(DateTime birthDate, string surname, string name, string patronymic, string passport, string email)
        {
            this.birthDate = birthDate;
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.passport = passport;
            this.email = email;
        }
        public User(string surname, string name, string patronymic)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
        }
    }


     class Client : User
    {
        string accountID;

        
        public Client(DateTime birthDate, string accountID, string surname, string name, string patronymic, string passport, string email) : base(birthDate, surname, name, patronymic, passport, email)
        {
        }
        public Client(string surname, string name, string patronymic) : base( surname, name, patronymic)
        {
        }
    }
    class Manager : User
    {
        public Manager(DateTime birthDate, string surname, string name, string patronymic, string passport, string email) : base(birthDate, surname, name, patronymic, passport, email)
        {
        }
    }

}

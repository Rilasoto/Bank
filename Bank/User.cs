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

        public User(DateTime birthDate, string surname, string name, string patronymic, string passport, string email)
        {
            this.birthDate = birthDate;
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.passport = passport;
            this.email = email;
        }
    }


    class Client : User
    {
        string accountID;

        public Client(DateTime birthDate, string accountID, string surname, string name, string patronymic, string passport, string email) : base(birthDate, surname, name, patronymic, passport, email)
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

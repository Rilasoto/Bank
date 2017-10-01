using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logics
{
    public class User
    {
        int id;
        bool isManager;
        DateTime birthDate;
        string surname, name, patronymic, passport, email;

        public int Id { get => id; set => id = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public string Patronymic { get => patronymic; set => patronymic = value; }
        public string Passport { get => passport; set => passport = value; }
        public string Email { get => email; set => email = value; }
        public bool IsManager { get => isManager; set => isManager = value; }

        public User()
        {

        }

        public User(string surname, string name, string patronymic)
        {
            this.Surname = surname;
            this.Name = name;
            this.Patronymic = patronymic;
        }

        public User(int id, bool isManager, DateTime birthDate, string surname, string name, string patronymic, string passport, string email)
        {
            this.Id = id;
            this.IsManager = isManager;
            this.birthDate = birthDate;
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.passport = passport;
            this.email = email;
        }
    }
}

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

        public int Id { get {return id;}  set {id = value;} }
        public string Surname { get { return surname; } set { surname = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Patronymic { get { return patronymic; } set { patronymic = value; } }
        public string Passport { get { return passport; } set { passport = value; } }
        public string Email { get { return  email; } set { email = value; } }
        public bool IsManager { get { return isManager; } set { isManager = value; } }

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

    public class Currency
    {
        float _in, _out;
        DateTime _date;

        public float In { get { return _in; } set { _in = value; } }
        public float Out { get { return _out; } set { _out = value; } }
        public DateTime Date { get { return _date; } set { _date = value; } }
    }
    

}

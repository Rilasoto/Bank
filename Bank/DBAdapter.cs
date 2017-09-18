using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logics;

namespace DBAdapter
{
    class DBAdapter
    {
        Controller controller;
        static DBAdapter instance;
        public static DBAdapter GetInstance()
        {
            if (instance == null)
                instance = new DBAdapter();
            return instance;
        }

        internal User Login(string login, string password) //Определяем кто это по типу
        {
            throw new NotImplementedException(); //Создавать объекты клиентов или манагеров будет адаптер, в базе можно какую-нибудь булевскую переменную (манагер/не манагер)
            
        }
    }
}

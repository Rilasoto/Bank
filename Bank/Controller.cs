using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBAdapter;
using System.Windows.Forms;
using GUI;

namespace Logics
{
    class Controller
    {
        DBAdapter.DBAdapter dBAdapter;
        Form activeForm;
        
        static Controller instance;
        public static Controller GetInstance()
        {
            if(instance==null)
            {
                instance = new Controller();
            }
            return instance;
        }

        internal void Login(string login, string password)
        {
            User loggedUser = dBAdapter.Login(login, password);
            if(loggedUser!=null)
            {
                OpenUserForm(loggedUser);
            }
        }
        void OpenUserForm(User loggedUser)
        {
            if (loggedUser != null)
            {
                Client loggedClient = loggedUser as Client;
                Manager loggedManager = loggedUser as Manager;

                if(loggedClient!=null)
                {
                    OpenClientForm(loggedClient);
                }
            }
        }
        void OpenClientForm(Client loggedClient)
        {
            new ClientForm
        }

    }
}

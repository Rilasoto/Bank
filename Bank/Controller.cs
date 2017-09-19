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

        public Controller()
        {
            dBAdapter = DBAdapter.DBAdapter.GetInstance();
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

        internal void OpenRegForm()
        {
            activeForm = new RegForm();
            activeForm.Show();
        }

        void OpenClientForm(Client loggedClient)
        {
            activeForm = new ClientForm();
            activeForm.Show();
        }

        internal bool CheckIfLoginExists(string login)
        {
            return dBAdapter.CheckIfLoginExists(login);
        }
    }
}

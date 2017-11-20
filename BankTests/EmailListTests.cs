using Microsoft.VisualStudio.TestTools.UnitTesting;
using GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GUI.Tests
{
    [TestClass()]
    public class EmailListTests
    {
      
        [TestMethod()]
        public void ShowEmailsTest()
        {
            // Тест на добавление пользователя
          int countbefore =  ForTest.Countrecords("Employees");

            RegForm form = new RegForm();
            form.nameBox.Text = "Влад";
            form.surnameBox.Text = "Харитонов";
            form.patronymicBox.Text = "Ванович";
            form.emailBox.Text = "123@gmail.com";
            form.passportID.Text = "123456789";
            form.buttonSubmit_Click(null, null);

           int countafter = ForTest.Countrecords("Employees");

            if (countafter - countbefore == 1)
            {
                // Успех  Вставить код 
            }
            else
            {
                // Провал Вставить код 
            }




        }
    }

}
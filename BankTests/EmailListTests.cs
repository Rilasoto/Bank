using Microsoft.VisualStudio.TestTools.UnitTesting;
using GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logics;
using System.IO;


namespace GUI.Tests
{
    [TestClass()]
    public class EmailListTests
    {
      
        [TestMethod()]
        public void EmployeesInsertCheck()
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

            Assert.AreEqual(countafter - 1, countbefore );
           
        }
        [TestMethod()]
        public void ImageinsertCheck()
        {
            // Тест на добавление Картинки (Изменил сам метод добавления на добавление картинки   imgLoc = "C:\\Users\\tvoix\\Desktop\\мемасики\\4.jpg"; по умолчанию)
            User user = new User();
            user.Id = 1017;
            byte[] imagebefore = ForTest.FindImage(user.Id);

            // картинка которая должна быть!!
            string imgLoc = "C:\\Users\\tvoix\\Desktop\\мемасики\\4.jpg";
            FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[]  img = br.ReadBytes((int)fs.Length);
            //

            ChangeClientInformtion form = new ChangeClientInformtion(user);
            form.nameBox.Text = "Влад";
            form.surnameBox.Text = "Харитонов";
            form.patronymicBox.Text = "Ванович";
            form.emailBox.Text = "123@gmail.com";
            form.passportBox.Text = "123456789";
            form.buttonSubmit_Click(null, null);

            byte[] imageafter = ForTest.FindImage(user.Id);

            Assert.AreEqual(img , imageafter);
           
        }
    }

}
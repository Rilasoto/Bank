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
          int countbefore =  ForTest.Countrecords();

            RegForm form = new RegForm();
            form.nameBox.Text = "Влад";
            form.surnameBox.Text = "Харитонов";
            form.patronymicBox.Text = "Ванович";
            form.buttonSubmit_Click(null, null);

           int countafter = ForTest.Countrecords();






        }
    }

}
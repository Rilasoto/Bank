using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DBAdapter;

namespace GUI.Tests
{
   public static class ForTest
    {
        static DB sql = new DB();
        public static int Countrecords(string Tables)
        {
           return  sql.RunSelect("Select * from "+ Tables + "").Rows.Count;
        }
        public static byte[] FindImage(int id)
        {
            string sql1 = "Select * From Image Where ID_employee = '" + id + "'";
            byte[] img = sql.RunSelectForImage(sql1);
            return img;
        }


    }
}

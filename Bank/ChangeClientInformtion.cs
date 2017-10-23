using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Logics;
using DBAdapter;
using System.IO;
using System.Data.SqlClient;

namespace GUI
{
    public partial class ChangeClientInformtion : Form
    {
        User user;
        public int day = 0, hour = 0, minute = 0;
        double second = 0.0;
        bool typedate = false;
        DB db;
        string imgLoc = "";
        SqlCommand cmd;
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-V4KR3NR;Initial Catalog=ProjectBank;Integrated Security=True");//Ринат


        public ChangeClientInformtion(User user)
        {
            InitializeComponent();
            this.user = user;
            timer1.Interval = 1000;
            timer1.Start();
            timer2.Interval = 2000;
            db = DB.GetInstance();

            string sql = "Select * From Image Where ID_employee = '" + user.Id + "'";
            byte[] img = db.RunSelectForImage(sql);

            if (img != null)
            {
                MemoryStream ms = new MemoryStream(img);
                if (ms != null)
                    pictureBox2.Image = Image.FromStream(ms);
            }

        }

        private void ChangeClientInformtion_Load(object sender, EventArgs e)
        {
            DataTable userr = db.RunSelect(@"Select * from Employees inner join Autorization on Employees.ID_Employee = Autorization.Employee_ID
                                                 where Employees.ID_Employee = '" + user.Id + "'");
            loginBox.Text = userr.Rows[0][1].ToString();
            passwordBox.Text = userr.Rows[0][1].ToString();
            surnameBox.Text = userr.Rows[0][1].ToString();
            nameBox.Text = userr.Rows[0][2].ToString();
            patronymicBox.Text = userr.Rows[0][3].ToString();
            dateBirth.Value = (DateTime)userr.Rows[0][4];
            emailBox.Text = userr.Rows[0][5].ToString();
            passportBox.Text = userr.Rows[0][6].ToString();
            richGivenBy.Text = userr.Rows[0][7].ToString();
            dateGiven.Value = (DateTime)userr.Rows[0][8];
            textRegAddress.Text = userr.Rows[0][9].ToString();

           

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // это скопированный код из формы регистрации, с кнопки регистрации. подходит ли он для вненсения измнений в существующую записьв бд?
            if (surnameBox.Text == "" || nameBox.Text == "" || patronymicBox.Text == "" || emailBox.Text == "" || passportBox.Text == "" || errorPassPic.Visible == true || pictureBox1.Visible ==true|| loginErrorPic.Visible == true || erroremail.Visible == true)
            {
                MessageBox.Show("Не все данные заполнены верно!", "Ошибка");
            }
            else
            {
                db.RunInsert(@"Update Employees
                                      set Surname ='"+ surnameBox.Text + @"',
                                          Name = '" + nameBox.Text + @"',
                                          Patronymic = '" + patronymicBox.Text + @"',
                                          Birth_Date = '" + dateBirth.Text + @"',
                                          Email = '" + emailBox.Text + @"',
                                          Passport_Seria = '" + passportBox.Text + @"',
                                          Passport_Givenby = '" + richGivenBy.Text + @"',
                                          Passport_Givenwhen = '" + dateGiven.Text + @"',
                                          Passport_RegistrationAddress = '" + textRegAddress.Text + @"'
                                          where ID_Employee = '"+ user.Id+"'");

                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    DataTable dt = db.RunSelect("Select * From Image where ID_employee = '" + user.Id + "' ");
                    if (dt.Rows.Count > 0)
                    {
                        connection.Open();
                        string sqlQuery = "update Image set Image = @images where ID_employee = '" + user.Id + "'  ";
                        cmd = new SqlCommand(sqlQuery, connection);
                        cmd.Parameters.Add(new SqlParameter("@images", img));
                        int N = cmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show(N.ToString() + " Фотография изменена");
                    }
                    else
                    {
                        connection.Open();
                        string sqlQuery = "insert into Image values('" + user.Id + "', @images)";
                        cmd = new SqlCommand(sqlQuery, connection);
                        cmd.Parameters.Add(new SqlParameter("@images", img));
                        int N = cmd.ExecuteNonQuery();
                        MessageBox.Show(N.ToString() + " Фотография добавлена");
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                cancelButton_Click(sender, e);

            }

           


        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            if (passwordBox.Text.Length<6)
            {
                pictureBox1.Visible = true;
            }

            Regex r = new Regex(@"[\d]"); // 
            Match m = r.Match(passwordBox.Text);
            if (!m.Success)
            {
                pictureBox1.Visible = true;
            }
            if (!passwordBox.Text.Any(Char.IsUpper))
            {
                pictureBox1.Visible = true;
            }
            Regex r1 = new Regex(@"[!@#$%^]"); // 
            Match m1 = r1.Match(passwordBox.Text);
            if (!m1.Success)
            {
                pictureBox1.Visible = true;
            }





            if (passwordBox.Text != password2Box.Text)
            {
                errorPassPic.Visible = true;
            }
            else
            {
                errorPassPic.Visible = false;
            }
        }

        private void loginBox_TextChanged(object sender, EventArgs e)
        {
            //db.RunSelect(@"Select * from Autorization 
            //                where Login ='"+ loginBox.Text + "'");
            //if (db.RunSelect(@"Select * from Autorization where Login ='" + loginBox.Text + "'").Rows.Count == 0)
            //{
            //    loginErrorPic.Visible = false;
            //}
            //else { loginErrorPic.Visible = true; }
        }

        private void ButtonImageChange_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Выберите фотографию для клиента";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    pictureBox2.ImageLocation = imgLoc;
                }
            }
            catch
            { }
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = "\\w+@\\w+\\.\\w+";
            if (!Regex.IsMatch(emailBox.Text, pattern))
            {
                erroremail.Visible = true;
            }
            else
            {
                erroremail.Visible = false;
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            typedate = !typedate;
        }
    }
}

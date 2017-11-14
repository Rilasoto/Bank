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
using System.IO;
using DBAdapter;
using System.Data.SqlClient;

namespace GUI
{
    public partial class RegForm : Form
    {
        public int day = 0, hour = 0, minute = 0;
        double second = 0.0;
        bool typedate = false;
        DB db;
        bool isEditMode = false;
        int userID;
        string imgLoc = "";
        SqlCommand cmd;
     SqlConnection   connection = new SqlConnection("Data Source=DESKTOP-V4KR3NR;Initial Catalog=ProjectBank;Integrated Security=True");//Ринат

        public RegForm()
        {
            InitializeComponent();

            timer1.Interval = 1000;
            timer1.Start();
            timer2.Interval = 2000;
            db = DB.GetInstance();
        }


        public int UserID
        {
            get { return this.userID; }
            set { this.userID = value; }
        }
        public bool IsEditMode
        {
            set { isEditMode = value; }
            get { return isEditMode; }
        }

        public void FillFieldsWithData(DataGridViewRow dr)
        {
            DataGridViewCellCollection cells = dr.Cells;

            loginBox.Text = cells["Login"].Value.ToString();
            passwordBox.Text = cells["Password"].Value.ToString();
            surnameBox.Text = cells["Surname"].Value.ToString();
            emailBox.Text = cells["Email"].Value.ToString();
            nameBox.Text = cells["Name"].Value.ToString();
            patronymicBox.Text = cells["Patronymic"].Value.ToString();
            dateBirth.Value = (DateTime)cells["Birth_Date"].Value;
            passportID.Text = cells["Passport_Seria"].Value.ToString();
            givenByRichText.Text = cells["Passport_GivenBy"].Value.ToString();
            dateGiven.Value = (DateTime)cells["Passport_GivenWhen"].Value;
            regAddressText.Text = cells["Passport_RegistrationAddress"].Value.ToString();
        }


        private void buttonSettings_Click(object sender, EventArgs e)
        {
            typedate = !typedate;
        }

        public void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (isEditMode)//если включен режим редактирования
            {

                if (surnameBox.Text == "" || nameBox.Text == "" || patronymicBox.Text == "" || emailBox.Text == "" || passportID.Text == "" || erroremail.Visible == true)
                {
                    MessageBox.Show("Некоторые поля заполнены неверно!");
                }
                else
                {
                    bool updateSucces = db.RunInsert("update Employees set Surname='" + surnameBox.Text +
                         "', Name='" + nameBox.Text +
                         "', Patronymic='" + patronymicBox.Text +
                         "', Email='" + emailBox.Text +
                         "', Passport_Seria='" + passportID.Text +
                         "', Passport_GivenBy='" + givenByRichText.Text +
                         "', Passport_GivenWhen='" + dateGiven.Value.ToString("yyyy-MM-dd") +
                         "', Passport_RegistrationAddress='" + regAddressText.Text +
                         "' where ID_Employee = " + userID);
                    if (updateSucces)
                    {
                        if (Owner is ClientsCatalog) //если была открыта из справочника
                        {
                            (Owner as ClientsCatalog).UpdateTable();
                            (Owner as ClientsCatalog).SelectRowWithID(userID);
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка записи");
                    }
                }
            }
            else
            {
                if (surnameBox.Text == "" || nameBox.Text == "" || patronymicBox.Text == "" || emailBox.Text == "" || passportID.Text == "" || errorPassPic.Visible == true || loginErrorPic.Visible == true || erroremail.Visible == true)
                {
                    MessageBox.Show("Не все данные заполнены верно!", "Ошибка");
                }
                else
                {
                    //if(db.RunInsert())
                    if (db.AddNewEmployee(loginBox.Text, passwordBox.Text, surnameBox.Text, nameBox.Text, patronymicBox.Text, dateBirth.Value, emailBox.Text, passportID.Text, givenByRichText.Text, dateGiven.Value, regAddressText.Text))
                    {
                        MessageBox.Show("Регистрация прошла успешно");
                        this.Close();
                        if (Owner is ClientsCatalog)
                        {
                            (Owner as ClientsCatalog).InitializeDatagrid();
                            (Owner as ClientsCatalog).SelectLastRow();
                        }
                        else
                        {
                            LoginForm.GetInstance().Show();
                        }
                    }
                    else
                        MessageBox.Show("Ошибка");
                }

            }
            try
            { 
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                DataTable dt = db.RunSelect("Select * From Image where ID_employee = '"+ UserID+"' ");
                if (dt.Rows.Count > 0)
                {
                    connection.Open();
                    string sqlQuery = "update Image set Image = @images where ID_employee = '"+UserID+"'  ";
                    cmd = new SqlCommand(sqlQuery, connection);
                    cmd.Parameters.Add(new SqlParameter("@images", img));
                    int N = cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show(N.ToString() + " Фотография изменена");
                }
                else
                {
                    connection.Open();
                    string sqlQuery = "insert into Image values('" + UserID + "', @images)";
                    cmd = new SqlCommand(sqlQuery, connection);
                    cmd.Parameters.Add(new SqlParameter("@images",img));
                    int N = cmd.ExecuteNonQuery();
                    MessageBox.Show(N.ToString() +" Фотография добавлена");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
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

        private void textBoxPassword2_TextChanged(object sender, EventArgs e)
        {
            if (passwordBox.Text != password2Box.Text)
            {
                errorPassPic.Visible = true;
            }
            else
            {
                errorPassPic.Visible = false;
            }
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            if (this.isEditMode)
            {
                loginBox.Enabled = false;
                passwordBox.Enabled = false;
                password2Box.Enabled = false;
                string sql = "Select * From Image Where ID_employee = '" + UserID + "'";
                //     DataTable dt = db.RunSelect("Select * From Image Where ID_employee = '"+UserID+"'");
               byte[] img =  db.RunSelectForImage(sql);

                    if (img != null)
                    {
                        MemoryStream ms = new MemoryStream(img);
                    if(ms !=null)
                        pictureBox1.Image = Image.FromStream(ms);
                    }

                }
        }
        

        private void loginBox_TextChanged(object sender, EventArgs e)
        {
            if (!isEditMode)
                timer2.Start();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner is ClientsCatalog)
                (Owner as ClientsCatalog).Enabled = true;
            else
                Owner.Show();
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
                    pictureBox1.ImageLocation = imgLoc;
                }
            }
            catch 
            { }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (loginBox.Text != "")
            {
                if (db.CheckIfLoginExists(loginBox.Text))
                    loginErrorPic.Visible = true;
                else
                    loginErrorPic.Visible = false;
                timer2.Stop();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date1 = DateTime.Now;
            second += 1;
            if (second >= 60)
            {
                second = 0;
                minute += 1;
            }
            if (minute >= 60)
            {
                minute = 0;
                hour += 1;
            }
            if (hour >= 24)
            {
                hour = 0;
                day += 1;
            }
            if (typedate)
            {
                labelTime.Text = day.ToString() + " дней " + hour.ToString() + " часов " + minute.ToString() + " минут " + Math.Round(second, 0).ToString() + " секунд";
            }
            else
            {
                labelTime.Text = date1.ToString();
            }
        }

    }
}

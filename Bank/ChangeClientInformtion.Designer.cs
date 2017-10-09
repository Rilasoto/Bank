namespace GUI
{
    partial class ChangeClientInformtion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textRegAddress = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.richGivenBy = new System.Windows.Forms.RichTextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.patronymicBox = new System.Windows.Forms.TextBox();
            this.passportBox = new System.Windows.Forms.MaskedTextBox();
            this.labelBirthDay = new System.Windows.Forms.Label();
            this.labelPassport = new System.Windows.Forms.Label();
            this.dateGiven = new System.Windows.Forms.DateTimePicker();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.emailBox = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.password2Box = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.labelRepeat = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.loginBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.errorPassPic = new System.Windows.Forms.PictureBox();
            this.loginErrorPic = new System.Windows.Forms.PictureBox();
            this.erroremail = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginErrorPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroremail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textRegAddress);
            this.groupBox1.Controls.Add(this.surnameBox);
            this.groupBox1.Controls.Add(this.labelSurname);
            this.groupBox1.Controls.Add(this.richGivenBy);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelPatronymic);
            this.groupBox1.Controls.Add(this.patronymicBox);
            this.groupBox1.Controls.Add(this.passportBox);
            this.groupBox1.Controls.Add(this.labelBirthDay);
            this.groupBox1.Controls.Add(this.labelPassport);
            this.groupBox1.Controls.Add(this.dateGiven);
            this.groupBox1.Controls.Add(this.dateBirth);
            this.groupBox1.Location = new System.Drawing.Point(221, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 189);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Паспортные данные";
            // 
            // textRegAddress
            // 
            this.textRegAddress.Location = new System.Drawing.Point(273, 150);
            this.textRegAddress.Name = "textRegAddress";
            this.textRegAddress.Size = new System.Drawing.Size(255, 20);
            this.textRegAddress.TabIndex = 12;
            // 
            // surnameBox
            // 
            this.surnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameBox.Location = new System.Drawing.Point(9, 37);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(169, 20);
            this.surnameBox.TabIndex = 5;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(6, 21);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 0;
            this.labelSurname.Text = "Фамилия";
            // 
            // richGivenBy
            // 
            this.richGivenBy.Location = new System.Drawing.Point(184, 76);
            this.richGivenBy.Name = "richGivenBy";
            this.richGivenBy.Size = new System.Drawing.Size(344, 50);
            this.richGivenBy.TabIndex = 11;
            this.richGivenBy.Text = "";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(181, 21);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Имя";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.Location = new System.Drawing.Point(184, 37);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(169, 20);
            this.nameBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(181, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кем выдан";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(181, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Когда выдан";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(270, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Адрес регистрации";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatronymic.Location = new System.Drawing.Point(356, 22);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(54, 13);
            this.labelPatronymic.TabIndex = 0;
            this.labelPatronymic.Text = "Отчество";
            // 
            // patronymicBox
            // 
            this.patronymicBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymicBox.Location = new System.Drawing.Point(359, 37);
            this.patronymicBox.Name = "patronymicBox";
            this.patronymicBox.Size = new System.Drawing.Size(169, 20);
            this.patronymicBox.TabIndex = 7;
            // 
            // passportBox
            // 
            this.passportBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passportBox.Location = new System.Drawing.Point(98, 76);
            this.passportBox.Mask = "0000-000000";
            this.passportBox.Name = "passportBox";
            this.passportBox.Size = new System.Drawing.Size(80, 20);
            this.passportBox.TabIndex = 9;
            this.passportBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelBirthDay
            // 
            this.labelBirthDay.AutoSize = true;
            this.labelBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirthDay.Location = new System.Drawing.Point(6, 60);
            this.labelBirthDay.Name = "labelBirthDay";
            this.labelBirthDay.Size = new System.Drawing.Size(86, 13);
            this.labelBirthDay.TabIndex = 0;
            this.labelBirthDay.Text = "Дата рождения";
            // 
            // labelPassport
            // 
            this.labelPassport.AutoSize = true;
            this.labelPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassport.Location = new System.Drawing.Point(95, 60);
            this.labelPassport.Name = "labelPassport";
            this.labelPassport.Size = new System.Drawing.Size(73, 13);
            this.labelPassport.TabIndex = 0;
            this.labelPassport.Text = "Серия номер";
            this.labelPassport.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateGiven
            // 
            this.dateGiven.CustomFormat = "yyyy-MM-dd";
            this.dateGiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateGiven.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateGiven.Location = new System.Drawing.Point(184, 150);
            this.dateGiven.Name = "dateGiven";
            this.dateGiven.Size = new System.Drawing.Size(83, 20);
            this.dateGiven.TabIndex = 8;
            // 
            // dateBirth
            // 
            this.dateBirth.CustomFormat = "";
            this.dateBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBirth.Location = new System.Drawing.Point(9, 76);
            this.dateBirth.MaxDate = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(83, 20);
            this.dateBirth.TabIndex = 8;
            this.dateBirth.Value = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTime.Location = new System.Drawing.Point(42, 257);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 16);
            this.labelTime.TabIndex = 23;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailBox.Location = new System.Drawing.Point(20, 182);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(169, 20);
            this.emailBox.TabIndex = 21;
            this.emailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.emailBox, "В формате 123@123.123");
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSubmit.Location = new System.Drawing.Point(494, 244);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(169, 22);
            this.buttonSubmit.TabIndex = 28;
            this.buttonSubmit.Text = "Зарегистрироваться";
            this.toolTip1.SetToolTip(this.buttonSubmit, "Тыкни сюда");
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(277, 26);
            this.labelTitle.TabIndex = 22;
            this.labelTitle.Text = "Редактирование данных";
            // 
            // password2Box
            // 
            this.password2Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password2Box.Location = new System.Drawing.Point(20, 143);
            this.password2Box.Name = "password2Box";
            this.password2Box.PasswordChar = '*';
            this.password2Box.Size = new System.Drawing.Size(169, 20);
            this.password2Box.TabIndex = 20;
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordBox.Location = new System.Drawing.Point(20, 104);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(169, 20);
            this.passwordBox.TabIndex = 19;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // labelRepeat
            // 
            this.labelRepeat.AutoSize = true;
            this.labelRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRepeat.Location = new System.Drawing.Point(17, 127);
            this.labelRepeat.Name = "labelRepeat";
            this.labelRepeat.Size = new System.Drawing.Size(100, 13);
            this.labelRepeat.TabIndex = 17;
            this.labelRepeat.Text = "Повторите пароль";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(17, 88);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(45, 13);
            this.labelPassword.TabIndex = 16;
            this.labelPassword.Text = "Пароль";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(17, 166);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(34, 13);
            this.labelEmail.TabIndex = 15;
            this.labelEmail.Text = "e-mail";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(669, 244);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(86, 22);
            this.cancelButton.TabIndex = 27;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.Location = new System.Drawing.Point(20, 65);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(169, 20);
            this.loginBox.TabIndex = 18;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(17, 49);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(38, 13);
            this.loginLabel.TabIndex = 13;
            this.loginLabel.Text = "Логин";
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSettings.BackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.BackgroundImage = global::Bank.Properties.Resources.w256h2561386955431setting2;
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Location = new System.Drawing.Point(17, 253);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(20, 20);
            this.buttonSettings.TabIndex = 14;
            this.buttonSettings.TabStop = false;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // errorPassPic
            // 
            this.errorPassPic.Cursor = System.Windows.Forms.Cursors.Default;
            this.errorPassPic.Image = global::Bank.Properties.Resources.exclamation_mark_red_md;
            this.errorPassPic.Location = new System.Drawing.Point(195, 145);
            this.errorPassPic.Name = "errorPassPic";
            this.errorPassPic.Size = new System.Drawing.Size(20, 17);
            this.errorPassPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.errorPassPic.TabIndex = 26;
            this.errorPassPic.TabStop = false;
            this.errorPassPic.Visible = false;
            // 
            // loginErrorPic
            // 
            this.loginErrorPic.Cursor = System.Windows.Forms.Cursors.Default;
            this.loginErrorPic.Image = global::Bank.Properties.Resources.exclamation_mark_red_md;
            this.loginErrorPic.Location = new System.Drawing.Point(195, 65);
            this.loginErrorPic.Name = "loginErrorPic";
            this.loginErrorPic.Size = new System.Drawing.Size(20, 17);
            this.loginErrorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginErrorPic.TabIndex = 25;
            this.loginErrorPic.TabStop = false;
            this.loginErrorPic.Visible = false;
            // 
            // erroremail
            // 
            this.erroremail.Cursor = System.Windows.Forms.Cursors.Default;
            this.erroremail.Image = global::Bank.Properties.Resources.exclamation_mark_red_md;
            this.erroremail.Location = new System.Drawing.Point(195, 183);
            this.erroremail.Name = "erroremail";
            this.erroremail.Size = new System.Drawing.Size(20, 18);
            this.erroremail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.erroremail.TabIndex = 24;
            this.erroremail.TabStop = false;
            this.erroremail.Visible = false;
            // 
            // ChangeClientInformtion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 352);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.errorPassPic);
            this.Controls.Add(this.loginErrorPic);
            this.Controls.Add(this.erroremail);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.password2Box);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.labelRepeat);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.loginLabel);
            this.Name = "ChangeClientInformtion";
            this.Text = "Меню редактирования пользователя";
            this.Load += new System.EventHandler(this.ChangeClientInformtion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginErrorPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroremail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textRegAddress;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.RichTextBox richGivenBy;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.TextBox patronymicBox;
        private System.Windows.Forms.MaskedTextBox passportBox;
        private System.Windows.Forms.Label labelBirthDay;
        private System.Windows.Forms.Label labelPassport;
        private System.Windows.Forms.DateTimePicker dateGiven;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox errorPassPic;
        private System.Windows.Forms.PictureBox loginErrorPic;
        private System.Windows.Forms.PictureBox erroremail;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox password2Box;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label labelRepeat;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label loginLabel;
    }
}
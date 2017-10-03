namespace GUI
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.patronymicLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рейтингМенеджеровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикОтпусковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стажToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.labelExperience = new System.Windows.Forms.Label();
            this.expa = new System.Windows.Forms.Label();
            this.rating = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.holidays = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.информацияОБанкеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.AutoSize = true;
            this.patronymicLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymicLabel.Location = new System.Drawing.Point(176, 138);
            this.patronymicLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(97, 23);
            this.patronymicLabel.TabIndex = 5;
            this.patronymicLabel.Text = "Отчество";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(177, 116);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(48, 23);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Имя";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLabel.Location = new System.Drawing.Point(176, 94);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(91, 23);
            this.surnameLabel.TabIndex = 7;
            this.surnameLabel.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Меню менеджера";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.информацияОБанкеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(580, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.рейтингМенеджеровToolStripMenuItem,
            this.графикОтпусковToolStripMenuItem,
            this.стажToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            // 
            // рейтингМенеджеровToolStripMenuItem
            // 
            this.рейтингМенеджеровToolStripMenuItem.Name = "рейтингМенеджеровToolStripMenuItem";
            this.рейтингМенеджеровToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.рейтингМенеджеровToolStripMenuItem.Text = "Рейтинг менеджеров";
            // 
            // графикОтпусковToolStripMenuItem
            // 
            this.графикОтпусковToolStripMenuItem.Name = "графикОтпусковToolStripMenuItem";
            this.графикОтпусковToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.графикОтпусковToolStripMenuItem.Text = "График отпусков";
            // 
            // стажToolStripMenuItem
            // 
            this.стажToolStripMenuItem.Name = "стажToolStripMenuItem";
            this.стажToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.стажToolStripMenuItem.Text = "Стаж";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 234);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Обслуживание";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelExperience
            // 
            this.labelExperience.AutoSize = true;
            this.labelExperience.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExperience.Location = new System.Drawing.Point(346, 116);
            this.labelExperience.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExperience.Name = "labelExperience";
            this.labelExperience.Size = new System.Drawing.Size(63, 23);
            this.labelExperience.TabIndex = 13;
            this.labelExperience.Text = "Стаж:";
            this.labelExperience.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // expa
            // 
            this.expa.AutoSize = true;
            this.expa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expa.Location = new System.Drawing.Point(486, 116);
            this.expa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.expa.Name = "expa";
            this.expa.Size = new System.Drawing.Size(57, 23);
            this.expa.TabIndex = 14;
            this.expa.Text = "Стаж";
            this.expa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rating.Location = new System.Drawing.Point(486, 93);
            this.rating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(57, 23);
            this.rating.TabIndex = 16;
            this.rating.Text = "Стаж";
            this.rating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(346, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Рейтинг";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // holidays
            // 
            this.holidays.AutoSize = true;
            this.holidays.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.holidays.Location = new System.Drawing.Point(486, 139);
            this.holidays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.holidays.Name = "holidays";
            this.holidays.Size = new System.Drawing.Size(57, 23);
            this.holidays.TabIndex = 18;
            this.holidays.Text = "Стаж";
            this.holidays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(346, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Дней отпуска";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(16, 94);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // информацияОБанкеToolStripMenuItem
            // 
            this.информацияОБанкеToolStripMenuItem.Name = "информацияОБанкеToolStripMenuItem";
            this.информацияОБанкеToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.информацияОБанкеToolStripMenuItem.Text = "Информация о банке";
            this.информацияОБанкеToolStripMenuItem.Click += new System.EventHandler(this.информацияОБанкеToolStripMenuItem_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 274);
            this.Controls.Add(this.holidays);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.expa);
            this.Controls.Add(this.labelExperience);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.patronymicLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label patronymicLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рейтингМенеджеровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикОтпусковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стажToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelExperience;
        private System.Windows.Forms.Label expa;
        private System.Windows.Forms.Label rating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label holidays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem информацияОБанкеToolStripMenuItem;
    }
}
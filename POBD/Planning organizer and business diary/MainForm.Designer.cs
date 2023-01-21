namespace Planning_organizer_and_business_diary
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.DateTimeNowText = new System.Windows.Forms.Label();
            this.DateTimeNowPicker = new System.Windows.Forms.DateTimePicker();
            this.CreateTaskButton = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DownloadImage = new System.Windows.Forms.Button();
            this.setBooksBackground = new System.Windows.Forms.RadioButton();
            this.setBlueBackground = new System.Windows.Forms.RadioButton();
            this.setFiguresBackgound = new System.Windows.Forms.RadioButton();
            this.GetHelp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TabBarOfDays = new System.Windows.Forms.TabControl();
            this.Mnd = new System.Windows.Forms.TabPage();
            this.MondayListBox = new System.Windows.Forms.CheckedListBox();
            this.Thus = new System.Windows.Forms.TabPage();
            this.ThuersdayListBox = new System.Windows.Forms.CheckedListBox();
            this.Wed = new System.Windows.Forms.TabPage();
            this.WednesdayListBox = new System.Windows.Forms.CheckedListBox();
            this.Thur = new System.Windows.Forms.TabPage();
            this.ThursdayListBox = new System.Windows.Forms.CheckedListBox();
            this.Frd = new System.Windows.Forms.TabPage();
            this.FridayListBox = new System.Windows.Forms.CheckedListBox();
            this.Sat = new System.Windows.Forms.TabPage();
            this.SaturdayListBox = new System.Windows.Forms.CheckedListBox();
            this.Sun = new System.Windows.Forms.TabPage();
            this.SundayListBox = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TabBarOfDays.SuspendLayout();
            this.Mnd.SuspendLayout();
            this.Thus.SuspendLayout();
            this.Wed.SuspendLayout();
            this.Thur.SuspendLayout();
            this.Frd.SuspendLayout();
            this.Sat.SuspendLayout();
            this.Sun.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(613, 69);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // DateTimeNowText
            // 
            this.DateTimeNowText.AutoSize = true;
            this.DateTimeNowText.BackColor = System.Drawing.Color.Transparent;
            this.DateTimeNowText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateTimeNowText.Location = new System.Drawing.Point(609, 12);
            this.DateTimeNowText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateTimeNowText.Name = "DateTimeNowText";
            this.DateTimeNowText.Size = new System.Drawing.Size(106, 24);
            this.DateTimeNowText.TabIndex = 13;
            this.DateTimeNowText.Text = "Час зараз";
            // 
            // DateTimeNowPicker
            // 
            this.DateTimeNowPicker.CustomFormat = "HH:mm:ss";
            this.DateTimeNowPicker.Enabled = false;
            this.DateTimeNowPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateTimeNowPicker.Location = new System.Drawing.Point(613, 40);
            this.DateTimeNowPicker.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimeNowPicker.Name = "DateTimeNowPicker";
            this.DateTimeNowPicker.Size = new System.Drawing.Size(219, 23);
            this.DateTimeNowPicker.TabIndex = 23;
            this.DateTimeNowPicker.ValueChanged += new System.EventHandler(this.DateTimeNowPicker_ValueChanged);
            // 
            // CreateTaskButton
            // 
            this.CreateTaskButton.Location = new System.Drawing.Point(0, 82);
            this.CreateTaskButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateTaskButton.Name = "CreateTaskButton";
            this.CreateTaskButton.Size = new System.Drawing.Size(211, 42);
            this.CreateTaskButton.TabIndex = 16;
            this.CreateTaskButton.Text = "Створити завдання";
            this.CreateTaskButton.UseVisualStyleBackColor = true;
            this.CreateTaskButton.Click += new System.EventHandler(this.CreateTaskButton_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.DownloadImage);
            this.groupBox1.Controls.Add(this.setBooksBackground);
            this.groupBox1.Controls.Add(this.setBlueBackground);
            this.groupBox1.Controls.Add(this.setFiguresBackgound);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(613, 281);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(219, 191);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Обрати заставку";
            // 
            // DownloadImage
            // 
            this.DownloadImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DownloadImage.Location = new System.Drawing.Point(24, 128);
            this.DownloadImage.Margin = new System.Windows.Forms.Padding(4);
            this.DownloadImage.Name = "DownloadImage";
            this.DownloadImage.Size = new System.Drawing.Size(155, 39);
            this.DownloadImage.TabIndex = 33;
            this.DownloadImage.Text = "Завантажити свою";
            this.DownloadImage.UseVisualStyleBackColor = true;
            this.DownloadImage.Click += new System.EventHandler(this.DownloadImage_Click);
            // 
            // setBooksBackground
            // 
            this.setBooksBackground.AutoSize = true;
            this.setBooksBackground.Location = new System.Drawing.Point(24, 95);
            this.setBooksBackground.Margin = new System.Windows.Forms.Padding(4);
            this.setBooksBackground.Name = "setBooksBackground";
            this.setBooksBackground.Size = new System.Drawing.Size(122, 24);
            this.setBooksBackground.TabIndex = 2;
            this.setBooksBackground.TabStop = true;
            this.setBooksBackground.Text = "Книжковий";
            this.setBooksBackground.UseVisualStyleBackColor = true;
            this.setBooksBackground.CheckedChanged += new System.EventHandler(this.SetBooksBackground_CheckedChanged);
            // 
            // setBlueBackground
            // 
            this.setBlueBackground.AutoSize = true;
            this.setBlueBackground.Location = new System.Drawing.Point(24, 66);
            this.setBlueBackground.Margin = new System.Windows.Forms.Padding(4);
            this.setBlueBackground.Name = "setBlueBackground";
            this.setBlueBackground.Size = new System.Drawing.Size(76, 24);
            this.setBlueBackground.TabIndex = 1;
            this.setBlueBackground.TabStop = true;
            this.setBlueBackground.Text = "Синій";
            this.setBlueBackground.UseVisualStyleBackColor = true;
            this.setBlueBackground.CheckedChanged += new System.EventHandler(this.SetBlueBackground_CheckedChanged);
            // 
            // setFiguresBackgound
            // 
            this.setFiguresBackgound.AutoSize = true;
            this.setFiguresBackgound.Location = new System.Drawing.Point(24, 38);
            this.setFiguresBackgound.Margin = new System.Windows.Forms.Padding(4);
            this.setFiguresBackgound.Name = "setFiguresBackgound";
            this.setFiguresBackgound.Size = new System.Drawing.Size(88, 24);
            this.setFiguresBackgound.TabIndex = 0;
            this.setFiguresBackgound.TabStop = true;
            this.setFiguresBackgound.Text = "Форми";
            this.setFiguresBackgound.UseVisualStyleBackColor = true;
            this.setFiguresBackgound.CheckedChanged += new System.EventHandler(this.SetFiguresBackgound_CheckedChanged);
            // 
            // GetHelp
            // 
            this.GetHelp.Location = new System.Drawing.Point(0, 28);
            this.GetHelp.Margin = new System.Windows.Forms.Padding(4);
            this.GetHelp.Name = "GetHelp";
            this.GetHelp.Size = new System.Drawing.Size(211, 39);
            this.GetHelp.TabIndex = 36;
            this.GetHelp.Text = "Помічник";
            this.GetHelp.UseVisualStyleBackColor = true;
            this.GetHelp.Click += new System.EventHandler(this.GetHelp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.CreateTaskButton);
            this.groupBox2.Controls.Add(this.GetHelp);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(613, 484);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(219, 134);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Робота з додатком";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TabBarOfDays
            // 
            this.TabBarOfDays.Controls.Add(this.Mnd);
            this.TabBarOfDays.Controls.Add(this.Thus);
            this.TabBarOfDays.Controls.Add(this.Wed);
            this.TabBarOfDays.Controls.Add(this.Thur);
            this.TabBarOfDays.Controls.Add(this.Frd);
            this.TabBarOfDays.Controls.Add(this.Sat);
            this.TabBarOfDays.Controls.Add(this.Sun);
            this.TabBarOfDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabBarOfDays.Location = new System.Drawing.Point(12, 12);
            this.TabBarOfDays.Name = "TabBarOfDays";
            this.TabBarOfDays.SelectedIndex = 0;
            this.TabBarOfDays.Size = new System.Drawing.Size(586, 610);
            this.TabBarOfDays.TabIndex = 41;
            // 
            // Mnd
            // 
            this.Mnd.Controls.Add(this.MondayListBox);
            this.Mnd.Location = new System.Drawing.Point(4, 31);
            this.Mnd.Name = "Mnd";
            this.Mnd.Padding = new System.Windows.Forms.Padding(3);
            this.Mnd.Size = new System.Drawing.Size(578, 575);
            this.Mnd.TabIndex = 0;
            this.Mnd.Text = "Понеділок";
            this.Mnd.UseVisualStyleBackColor = true;
            // 
            // MondayListBox
            // 
            this.MondayListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MondayListBox.FormattingEnabled = true;
            this.MondayListBox.Location = new System.Drawing.Point(3, 3);
            this.MondayListBox.Name = "MondayListBox";
            this.MondayListBox.Size = new System.Drawing.Size(572, 569);
            this.MondayListBox.TabIndex = 26;
            // 
            // Thus
            // 
            this.Thus.Controls.Add(this.ThuersdayListBox);
            this.Thus.Location = new System.Drawing.Point(4, 31);
            this.Thus.Name = "Thus";
            this.Thus.Padding = new System.Windows.Forms.Padding(3);
            this.Thus.Size = new System.Drawing.Size(578, 575);
            this.Thus.TabIndex = 1;
            this.Thus.Text = "Вівторок";
            this.Thus.UseVisualStyleBackColor = true;
            // 
            // ThuersdayListBox
            // 
            this.ThuersdayListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThuersdayListBox.FormattingEnabled = true;
            this.ThuersdayListBox.Location = new System.Drawing.Point(3, 3);
            this.ThuersdayListBox.Name = "ThuersdayListBox";
            this.ThuersdayListBox.Size = new System.Drawing.Size(572, 569);
            this.ThuersdayListBox.TabIndex = 27;
            // 
            // Wed
            // 
            this.Wed.Controls.Add(this.WednesdayListBox);
            this.Wed.Location = new System.Drawing.Point(4, 31);
            this.Wed.Name = "Wed";
            this.Wed.Padding = new System.Windows.Forms.Padding(3);
            this.Wed.Size = new System.Drawing.Size(578, 575);
            this.Wed.TabIndex = 2;
            this.Wed.Text = "Середа";
            this.Wed.UseVisualStyleBackColor = true;
            // 
            // WednesdayListBox
            // 
            this.WednesdayListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WednesdayListBox.FormattingEnabled = true;
            this.WednesdayListBox.Location = new System.Drawing.Point(3, 3);
            this.WednesdayListBox.Name = "WednesdayListBox";
            this.WednesdayListBox.Size = new System.Drawing.Size(572, 569);
            this.WednesdayListBox.TabIndex = 27;
            // 
            // Thur
            // 
            this.Thur.Controls.Add(this.ThursdayListBox);
            this.Thur.Location = new System.Drawing.Point(4, 31);
            this.Thur.Name = "Thur";
            this.Thur.Padding = new System.Windows.Forms.Padding(3);
            this.Thur.Size = new System.Drawing.Size(578, 575);
            this.Thur.TabIndex = 3;
            this.Thur.Text = "Четвер";
            this.Thur.UseVisualStyleBackColor = true;
            // 
            // ThursdayListBox
            // 
            this.ThursdayListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThursdayListBox.FormattingEnabled = true;
            this.ThursdayListBox.Location = new System.Drawing.Point(3, 3);
            this.ThursdayListBox.Name = "ThursdayListBox";
            this.ThursdayListBox.Size = new System.Drawing.Size(572, 569);
            this.ThursdayListBox.TabIndex = 27;
            // 
            // Frd
            // 
            this.Frd.Controls.Add(this.FridayListBox);
            this.Frd.Location = new System.Drawing.Point(4, 31);
            this.Frd.Name = "Frd";
            this.Frd.Padding = new System.Windows.Forms.Padding(3);
            this.Frd.Size = new System.Drawing.Size(578, 575);
            this.Frd.TabIndex = 4;
            this.Frd.Text = "П\'ятниця";
            this.Frd.UseVisualStyleBackColor = true;
            // 
            // FridayListBox
            // 
            this.FridayListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FridayListBox.FormattingEnabled = true;
            this.FridayListBox.Location = new System.Drawing.Point(3, 3);
            this.FridayListBox.Name = "FridayListBox";
            this.FridayListBox.Size = new System.Drawing.Size(572, 569);
            this.FridayListBox.TabIndex = 27;
            // 
            // Sat
            // 
            this.Sat.Controls.Add(this.SaturdayListBox);
            this.Sat.Location = new System.Drawing.Point(4, 31);
            this.Sat.Name = "Sat";
            this.Sat.Padding = new System.Windows.Forms.Padding(3);
            this.Sat.Size = new System.Drawing.Size(578, 575);
            this.Sat.TabIndex = 5;
            this.Sat.Text = "Субота";
            this.Sat.UseVisualStyleBackColor = true;
            // 
            // SaturdayListBox
            // 
            this.SaturdayListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaturdayListBox.FormattingEnabled = true;
            this.SaturdayListBox.Location = new System.Drawing.Point(3, 3);
            this.SaturdayListBox.Name = "SaturdayListBox";
            this.SaturdayListBox.Size = new System.Drawing.Size(572, 569);
            this.SaturdayListBox.TabIndex = 27;
            // 
            // Sun
            // 
            this.Sun.Controls.Add(this.SundayListBox);
            this.Sun.Location = new System.Drawing.Point(4, 31);
            this.Sun.Name = "Sun";
            this.Sun.Padding = new System.Windows.Forms.Padding(3);
            this.Sun.Size = new System.Drawing.Size(578, 575);
            this.Sun.TabIndex = 6;
            this.Sun.Text = "Неділя";
            this.Sun.UseVisualStyleBackColor = true;
            // 
            // SundayListBox
            // 
            this.SundayListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SundayListBox.FormattingEnabled = true;
            this.SundayListBox.Location = new System.Drawing.Point(3, 3);
            this.SundayListBox.Name = "SundayListBox";
            this.SundayListBox.Size = new System.Drawing.Size(572, 569);
            this.SundayListBox.TabIndex = 27;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(840, 621);
            this.Controls.Add(this.TabBarOfDays);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DateTimeNowPicker);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.DateTimeNowText);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlanningOrganizer&BusinessDiary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.TabBarOfDays.ResumeLayout(false);
            this.Mnd.ResumeLayout(false);
            this.Thus.ResumeLayout(false);
            this.Wed.ResumeLayout(false);
            this.Thur.ResumeLayout(false);
            this.Frd.ResumeLayout(false);
            this.Sat.ResumeLayout(false);
            this.Sun.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label DateTimeNowText;
        private System.Windows.Forms.Button CreateTaskButton;
        private System.Windows.Forms.DateTimePicker DateTimeNowPicker;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton setBooksBackground;
        private System.Windows.Forms.RadioButton setBlueBackground;
        private System.Windows.Forms.RadioButton setFiguresBackgound;
        private System.Windows.Forms.Button GetHelp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DownloadImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl TabBarOfDays;
        private System.Windows.Forms.TabPage Mnd;
        private System.Windows.Forms.TabPage Thus;
        private System.Windows.Forms.TabPage Wed;
        private System.Windows.Forms.TabPage Thur;
        private System.Windows.Forms.TabPage Frd;
        private System.Windows.Forms.TabPage Sat;
        private System.Windows.Forms.TabPage Sun;
        private System.Windows.Forms.CheckedListBox MondayListBox;
        private System.Windows.Forms.CheckedListBox ThuersdayListBox;
        private System.Windows.Forms.CheckedListBox WednesdayListBox;
        private System.Windows.Forms.CheckedListBox ThursdayListBox;
        private System.Windows.Forms.CheckedListBox FridayListBox;
        private System.Windows.Forms.CheckedListBox SaturdayListBox;
        private System.Windows.Forms.CheckedListBox SundayListBox;
    }
}


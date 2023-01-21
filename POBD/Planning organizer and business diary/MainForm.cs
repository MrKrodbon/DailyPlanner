using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Planning_organizer_and_business_diary
{
    public partial class MainForm : Form
    {
        readonly Setting _setting = null;


        public MainForm()
        {
            InitializeComponent();
            DateTimeNowPicker.Format = DateTimePickerFormat.Time;
            DateTimeNowPicker.ValueChanged += DateTimeNowPicker_ValueChanged;
            _setting = Setting.GetSetting();
            InitSettings();
        }

        private void DateTimeNowText_Click(object sender, EventArgs e)
        {
            Timer.Start();
            DateTimeNowPicker.Text = DateTime.Now.ToLongTimeString();

        }
        private void DateTimeNowPicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimeNowPicker.Format = DateTimePickerFormat.Custom;


        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTimeNowPicker.Text = DateTime.Now.ToLongTimeString();
            Timer.Start();
        }
        private void SetBlueBackground_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (setBlueBackground.Checked)
                {
                    this.BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + @"\img\BlueColor.jpg");
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Виникла помилка під час зміни фону  " + ex.Message);
            }

        }
        private void GetHelp_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            try
            {
                process.StartInfo.FileName = Directory.GetCurrentDirectory() + @"\Help.txt";
                process.Start();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void InitSettings()
        {
            MondayListBox.Items.Add(_setting.Monday_Task + MondayListBox.SelectedItems);

            ThuersdayListBox.Items.Add( _setting.Thuesday_Task);
            WednesdayListBox.Items.Add(_setting.Wendesday_Task);
            ThursdayListBox.Items.Add(_setting.Thursday_Task);
            FridayListBox.Items.Add(_setting.Friday_Task);
            SaturdayListBox.Items.Add(_setting.Saturday_Task);
            SundayListBox.Items.Add(_setting.Sunday_Task);
        }
        private void saveSettings()
        {

            _setting.Monday_Task = MondayListBox.Text + MondayListBox.GetSelected(MondayListBox.SelectedIndex);
            _setting.Thuesday_Task = ThuersdayListBox.Text;
            _setting.Wendesday_Task = WednesdayListBox.Text;
            _setting.Thursday_Task = ThursdayListBox.Text;
            _setting.Friday_Task = FridayListBox.Text;
            _setting.Saturday_Task = SaturdayListBox.Text;
            _setting.Sunday_Task = SundayListBox.Text;
            _setting.Save();

        }
        private void SetFiguresBackgound_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (setFiguresBackgound.Checked)
                {
                    BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + @"\img\Figures.gif");
                    BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Виникла помилка під час зміни фону  " + ex.Message);
            }


        }

        private void DownloadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG|*.JPG;*.BMP;*.GIF;*.PNG|All files(*.*)|*.*"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    BackgroundImage = new Bitmap(open.FileName);
                    BackgroundImageLayout = ImageLayout.Stretch;


                }
                catch
                {
                    MessageBox.Show("Неможливо відкрити обраний файл", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();
            Application.Exit();
        }

        private void SetBooksBackground_CheckedChanged(object sender, EventArgs e)
        {
            if (setBooksBackground.Checked)
            {
                BackgroundImage = new Bitmap(Directory.GetCurrentDirectory() + @"\img\Books.jpg");
                BackgroundImageLayout = ImageLayout.Stretch;

            }
        }

        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            NewTask newTask = new NewTask();
            newTask.ShowDialog();


            switch (TabBarOfDays.SelectedIndex)
            {
                case 0:
                    MondayListBox.Items.Add(newTask.dateTimePicker1.Text + "  " + newTask.TaskText.Text + Environment.NewLine);
                    
                    break;

                case 1:
                    ThuersdayListBox.Items.Add(newTask.dateTimePicker1.Text + "  " + newTask.TaskText.Text + Environment.NewLine);
                    
                    break;
                case 2:
                    WednesdayListBox.Items.Add(newTask.dateTimePicker1.Text + "  " + newTask.TaskText.Text + Environment.NewLine);
                    
                    break;
                case 3:
                    ThursdayListBox.Items.Add(newTask.dateTimePicker1.Text + "  " + newTask.TaskText.Text + Environment.NewLine);
                   
                    break;
                case 4:
                    FridayListBox.Items.Add(newTask.dateTimePicker1.Text + "  " + newTask.TaskText.Text + Environment.NewLine);

                    
                    break;
                case 5:
                    SaturdayListBox.Items.Add(newTask.dateTimePicker1.Text + "  " + newTask.TaskText.Text + Environment.NewLine);
                    
                    break;
                case 6:
                    SundayListBox.Items.Add(newTask.dateTimePicker1.Text + "  " + newTask.TaskText.Text + Environment.NewLine);
               
                    break;
                default:
                    MessageBox.Show("Не був обраний день тижня");
                    break;
            }


        }
    }
}

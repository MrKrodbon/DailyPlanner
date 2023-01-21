using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planning_organizer_and_business_diary
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
            this.timer1.Start();
        }

        private void UserSettings_Load(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(2);
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                button1.Enabled = true;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
            
            MainForm pobd = new MainForm();
            this.Hide();
            pobd.ShowDialog();
            
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private System.Windows.Forms.Timer aTimer;
        int counter;
        int i = 0;
        int minuter;
        //int existCounter;
        //int existMinuter;

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            aTimer.Stop();
        }

        private void Time1_Click(object sender, EventArgs e)
        {

        }
        public void getSec(int counter)
        {
            int getCounter = counter;
            Time2.Text = getCounter.ToString();
        }

        private void Time2_Click(object sender, EventArgs e)
        {
            int countera;

            if (i == 0)
                counter = int.Parse(Second.Text);
            if (counter == 0 && minuter > 0)
            {
                counter = 60;
                minuter = minuter - 1;
            }

            counter = counter - 1;
            countera = counter;

            if (counter == 0 && minuter == 0)

            {
                aTimer.Stop();
                MessageBox.Show("Done");
                aTimer.Stop();

            }
            if (counter < 10)
            {
                Time2.Text = "0";
                Time2.Text += counter.ToString();
            }
            else
                Time2.Text = counter.ToString();
            if (minuter < 10)
            {
                Time1.Text = "0";
                Time1.Text += minuter.ToString();
            }
            else
                Time1.Text = minuter.ToString();

            getSec(countera);
            i++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int counter = 0;
            int i = 0;
            int minuter = 0;*/

            if (i == 0)
            {
                counter = int.Parse(Second.Text);
                minuter = int.Parse(Minu.Text);

            }


            aTimer = new System.Windows.Forms.Timer();

            aTimer.Tick += new EventHandler(Time2_Click);

            aTimer.Interval = 1000; // 1 second

            aTimer.Start();
            if (counter < 10)
            {
                Time2.Text = "0";
                Time2.Text += counter.ToString();
            }
            else
                Time2.Text = counter.ToString();
            if (minuter < 10)
            {
                Time1.Text = "0";
                Time1.Text += minuter.ToString();
            }
            else
                Time1.Text = minuter.ToString();

            i++;
        }
    }
}

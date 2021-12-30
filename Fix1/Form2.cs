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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private System.Windows.Forms.Timer aTimer;

           private void Form2_Load(object sender, EventArgs e)
        {

        }

        int counter = 0;
        int i = 0;
        int minuter = 0; 

        private void button1_Click(object sender, EventArgs e)
        {
            //int counter = 0;
            //int i = 0;
            //int minuter = 0;

            if (i == 0)
            {
                counter = int.Parse(Second.Text);
                minuter = int.Parse(Minu.Text);

            }    
           

            aTimer = new System.Windows.Forms.Timer();

            aTimer.Tick += new EventHandler(label2_Click);

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

        private void label2_Click(object sender, EventArgs e)
        {

            if (i == 0)
                counter = int.Parse(Second.Text);
            if (counter == 0 && minuter > 0)
            {
                counter = 60;
                minuter = minuter - 1; 
            }

            counter = counter - 1;

            if (counter == 0 && minuter ==0)

            {
                aTimer.Stop();
                MessageBox.Show("Đã đếm xong");
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


           
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 b = new Form1();
            b.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            aTimer.Stop();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}









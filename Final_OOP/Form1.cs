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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Hide other user controls
            userControl31.Hide();
            userControl21.Hide();

            //show current control
            userControl11.Show();
            userControl11.BringToFront();

        }
        private void button2_Click(object sender, EventArgs e)
        {

            //Hide other user controls
            userControl31.Hide();
            userControl11.Hide();

            //show current control
            userControl21.Show();
            userControl21.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Hide other user controls
            userControl11.Hide();
            userControl21.Hide();

            //show current control
            userControl31.Show();
            userControl11.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

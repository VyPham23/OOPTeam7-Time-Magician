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
            Form2 a = new Form2();
            this.Hide();
            a.ShowDialog();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 c = new Form3();
            this.Hide();
            c.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusicPlayer d = new MusicPlayer();
            this.Hide();
            d.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
    }
}

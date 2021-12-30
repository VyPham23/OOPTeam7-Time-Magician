using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp4
{   
    public partial class Form3 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=CUONGLEE\SQLEXPRESS;Initial Catalog=TodoList;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from DataTodoList ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.AutoGenerateColumns = false;
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 b = new Form1();
            b.ShowDialog();
        }
        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_task.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            tb_task.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            cb_priority.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            dtime_duedate.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            cb_done.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into DataTodoList values('"+tb_task.Text+ "', '"+cb_priority.Text+ "', '"+dtime_duedate.Text+ "', '"+cb_done.Text+ "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtime_duedate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from DataTodoList where Task= '"+tb_task.Text+ "'";
            command.ExecuteNonQuery();
            loaddata();

        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update DataTodoList set Priority= '"+cb_priority.Text+ "', DueDate='"+dtime_duedate.Text+ "', Done='"+cb_done.Text+ "' where Task= '"+tb_task.Text+ "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            tb_task.Text = "";
            cb_priority.Text = "";
            dtime_duedate.Text = "01/01/2021";
            cb_done.Text = "";
        }
    }
}

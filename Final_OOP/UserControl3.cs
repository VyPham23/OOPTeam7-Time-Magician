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
    public partial class UserControl3 : UserControl
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=CUONGLEE\SQLEXPRESS;Initial Catalog = TodoList; Integrated Security = True";
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
        public UserControl3()
        {
            InitializeComponent();
        }
        private void UserControl3_Load_1(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //tb_task.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            tb_task.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            cb_priority.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            dtime_duedate.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            cb_done.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into DataTodoList values('" + tb_task.Text + "', '" + cb_priority.Text + "', '" + dtime_duedate.Text + "', '" + cb_done.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void bt_edit_Click_1(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update DataTodoList set Priority= '" + cb_priority.Text + "', DueDate='" + dtime_duedate.Text + "', Done='" + cb_done.Text + "' where Task= '" + tb_task.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void bt_delete_Click_1(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from DataTodoList where Task= '" + tb_task.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void bt_reset_Click_1(object sender, EventArgs e)
        {
            tb_task.Text = "";
            cb_priority.Text = "";
            dtime_duedate.Text = "01/01/2022";
            cb_done.Text = "";
        }
       
    }
}

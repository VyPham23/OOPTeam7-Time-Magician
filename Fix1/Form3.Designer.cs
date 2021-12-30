
namespace WindowsFormsApp4
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_done = new System.Windows.Forms.ComboBox();
            this.cb_priority = new System.Windows.Forms.ComboBox();
            this.dtime_duedate = new System.Windows.Forms.DateTimePicker();
            this.tb_task = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 418);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 23);
            this.button2.TabIndex = 40;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(854, 222);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Task";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Task";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Priority";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Priority";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DueDate";
            this.Column3.HeaderText = "Due Date";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Done";
            this.Column4.HeaderText = "Done";
            this.Column4.Name = "Column4";
            this.Column4.Width = 75;
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(706, 372);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(116, 30);
            this.bt_reset.TabIndex = 43;
            this.bt_reset.Text = "Reset Task";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(706, 264);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(116, 30);
            this.bt_add.TabIndex = 44;
            this.bt_add.Text = "Add Task";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(706, 300);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(116, 30);
            this.bt_edit.TabIndex = 45;
            this.bt_edit.Text = "Edit Task";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(706, 336);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(116, 30);
            this.bt_delete.TabIndex = 46;
            this.bt_delete.Text = "Delete Task";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 245);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_done);
            this.groupBox2.Controls.Add(this.cb_priority);
            this.groupBox2.Controls.Add(this.dtime_duedate);
            this.groupBox2.Controls.Add(this.tb_task);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(5, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 165);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // cb_done
            // 
            this.cb_done.FormattingEnabled = true;
            this.cb_done.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cb_done.Location = new System.Drawing.Point(423, 69);
            this.cb_done.Name = "cb_done";
            this.cb_done.Size = new System.Drawing.Size(67, 21);
            this.cb_done.TabIndex = 55;
            // 
            // cb_priority
            // 
            this.cb_priority.FormattingEnabled = true;
            this.cb_priority.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.cb_priority.Location = new System.Drawing.Point(181, 69);
            this.cb_priority.Name = "cb_priority";
            this.cb_priority.Size = new System.Drawing.Size(98, 21);
            this.cb_priority.TabIndex = 54;
            this.cb_priority.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtime_duedate
            // 
            this.dtime_duedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtime_duedate.Location = new System.Drawing.Point(181, 105);
            this.dtime_duedate.Name = "dtime_duedate";
            this.dtime_duedate.Size = new System.Drawing.Size(202, 20);
            this.dtime_duedate.TabIndex = 53;
            this.dtime_duedate.ValueChanged += new System.EventHandler(this.dtime_duedate_ValueChanged);
            // 
            // tb_task
            // 
            this.tb_task.Location = new System.Drawing.Point(181, 32);
            this.tb_task.Name = "tb_task";
            this.tb_task.Size = new System.Drawing.Size(377, 20);
            this.tb_task.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(376, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Done";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "Due Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Priority";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Task";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "To Do List";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_priority;
        private System.Windows.Forms.DateTimePicker dtime_duedate;
        private System.Windows.Forms.TextBox tb_task;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_done;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
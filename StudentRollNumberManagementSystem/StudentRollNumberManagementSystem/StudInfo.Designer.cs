namespace StudentRollNumberManagementSystem
{
    partial class StudInfo
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
            this.components = new System.ComponentModel.Container();
            this.but_insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentMgtDataSet = new StudentRollNumberManagementSystem.StudentMgtDataSet();
            this.studentMgtDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userLoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userLoginTableAdapter = new StudentRollNumberManagementSystem.StudentMgtDataSetTableAdapters.userLoginTableAdapter();
            this.studentMgtDataSet1 = new StudentRollNumberManagementSystem.StudentMgtDataSet1();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoTableAdapter = new StudentRollNumberManagementSystem.StudentMgtDataSet1TableAdapters.studentInfoTableAdapter();
            this.rollnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examseatnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prnnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMgtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMgtDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMgtDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // but_insert
            // 
            this.but_insert.Location = new System.Drawing.Point(165, 183);
            this.but_insert.Name = "but_insert";
            this.but_insert.Size = new System.Drawing.Size(75, 23);
            this.but_insert.TabIndex = 1;
            this.but_insert.Text = "delete";
            this.but_insert.UseVisualStyleBackColor = true;
            this.but_insert.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PRN No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seat No. :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Roll No. :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(99, 93);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(99, 128);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollnumberDataGridViewTextBoxColumn,
            this.examseatnoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.prnnumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(273, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(502, 230);
            this.dataGridView1.TabIndex = 10;
            // 
            // studentMgtDataSet
            // 
            this.studentMgtDataSet.DataSetName = "StudentMgtDataSet";
            this.studentMgtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentMgtDataSetBindingSource
            // 
            this.studentMgtDataSetBindingSource.DataSource = this.studentMgtDataSet;
            this.studentMgtDataSetBindingSource.Position = 0;
            // 
            // userLoginBindingSource
            // 
            this.userLoginBindingSource.DataMember = "userLogin";
            this.userLoginBindingSource.DataSource = this.studentMgtDataSetBindingSource;
            // 
            // userLoginTableAdapter
            // 
            this.userLoginTableAdapter.ClearBeforeFill = true;
            // 
            // studentMgtDataSet1
            // 
            this.studentMgtDataSet1.DataSetName = "StudentMgtDataSet1";
            this.studentMgtDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "studentInfo";
            this.studentInfoBindingSource.DataSource = this.studentMgtDataSet1;
            // 
            // studentInfoTableAdapter
            // 
            this.studentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // rollnumberDataGridViewTextBoxColumn
            // 
            this.rollnumberDataGridViewTextBoxColumn.DataPropertyName = "roll_number";
            this.rollnumberDataGridViewTextBoxColumn.HeaderText = "roll_number";
            this.rollnumberDataGridViewTextBoxColumn.Name = "rollnumberDataGridViewTextBoxColumn";
            // 
            // examseatnoDataGridViewTextBoxColumn
            // 
            this.examseatnoDataGridViewTextBoxColumn.DataPropertyName = "exam_seat_no";
            this.examseatnoDataGridViewTextBoxColumn.HeaderText = "exam_seat_no";
            this.examseatnoDataGridViewTextBoxColumn.Name = "examseatnoDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // prnnumberDataGridViewTextBoxColumn
            // 
            this.prnnumberDataGridViewTextBoxColumn.DataPropertyName = "prn_number";
            this.prnnumberDataGridViewTextBoxColumn.HeaderText = "prn_number";
            this.prnnumberDataGridViewTextBoxColumn.Name = "prnnumberDataGridViewTextBoxColumn";
            // 
            // StudInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 262);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_insert);
            this.Name = "StudInfo";
            this.Text = "StudInfo";
            this.Load += new System.EventHandler(this.StudInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMgtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMgtDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMgtDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button but_insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentMgtDataSetBindingSource;
        private StudentMgtDataSet studentMgtDataSet;
        private System.Windows.Forms.BindingSource userLoginBindingSource;
        private StudentMgtDataSetTableAdapters.userLoginTableAdapter userLoginTableAdapter;
        private StudentMgtDataSet1 studentMgtDataSet1;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private StudentMgtDataSet1TableAdapters.studentInfoTableAdapter studentInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examseatnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prnnumberDataGridViewTextBoxColumn;
    }
}
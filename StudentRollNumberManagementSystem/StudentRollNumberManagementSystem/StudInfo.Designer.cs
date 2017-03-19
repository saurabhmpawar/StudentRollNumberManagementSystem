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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_rollno = new System.Windows.Forms.TextBox();
            this.txt_seatno = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_prn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rollnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examseatnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prnnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentMgtDataSet1 = new StudentRollNumberManagementSystem.StudentMgtDataSet1();
            this.studentMgtDataSet = new StudentRollNumberManagementSystem.StudentMgtDataSet();
            this.studentMgtDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userLoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userLoginTableAdapter = new StudentRollNumberManagementSystem.StudentMgtDataSetTableAdapters.userLoginTableAdapter();
            this.studentInfoTableAdapter = new StudentRollNumberManagementSystem.StudentMgtDataSet1TableAdapters.studentInfoTableAdapter();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMgtDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMgtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMgtDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // txt_rollno
            // 
            this.txt_rollno.Location = new System.Drawing.Point(99, 26);
            this.txt_rollno.Name = "txt_rollno";
            this.txt_rollno.Size = new System.Drawing.Size(100, 20);
            this.txt_rollno.TabIndex = 5;
            // 
            // txt_seatno
            // 
            this.txt_seatno.Location = new System.Drawing.Point(99, 57);
            this.txt_seatno.Name = "txt_seatno";
            this.txt_seatno.Size = new System.Drawing.Size(100, 20);
            this.txt_seatno.TabIndex = 6;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(99, 93);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 7;
            // 
            // txt_prn
            // 
            this.txt_prn.Location = new System.Drawing.Point(99, 128);
            this.txt_prn.Name = "txt_prn";
            this.txt_prn.Size = new System.Drawing.Size(100, 20);
            this.txt_prn.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
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
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
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
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "studentInfo";
            this.studentInfoBindingSource.DataSource = this.studentMgtDataSet1;
            // 
            // studentMgtDataSet1
            // 
            this.studentMgtDataSet1.DataSetName = "StudentMgtDataSet1";
            this.studentMgtDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // studentInfoTableAdapter
            // 
            this.studentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(93, 183);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(174, 183);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // StudInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 262);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_prn);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_seatno);
            this.Controls.Add(this.txt_rollno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudInfo";
            this.Text = "StudInfo";
            this.Load += new System.EventHandler(this.StudInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMgtDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMgtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMgtDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_rollno;
        private System.Windows.Forms.TextBox txt_seatno;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_prn;
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
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
    }
}
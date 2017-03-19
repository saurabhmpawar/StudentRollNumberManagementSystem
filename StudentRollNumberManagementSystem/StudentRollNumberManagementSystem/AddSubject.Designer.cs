namespace StudentRollNumberManagementSystem
{
    partial class AddSubject
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
            this.txt_subjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_termworkMark = new System.Windows.Forms.TextBox();
            this.txt_failMArk = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.subjectidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjetnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.twmarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minmarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentMgtDataSet3 = new StudentRollNumberManagementSystem.StudentMgtDataSet3();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.subjectsTableAdapter = new StudentRollNumberManagementSystem.StudentMgtDataSet3TableAdapters.subjectsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMgtDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_subjectName
            // 
            this.txt_subjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subjectName.Location = new System.Drawing.Point(229, 45);
            this.txt_subjectName.Name = "txt_subjectName";
            this.txt_subjectName.Size = new System.Drawing.Size(255, 26);
            this.txt_subjectName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Semistor :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Min Term Work Mark :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "TermWork Marks :";
            // 
            // txt_termworkMark
            // 
            this.txt_termworkMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_termworkMark.Location = new System.Drawing.Point(229, 134);
            this.txt_termworkMark.Name = "txt_termworkMark";
            this.txt_termworkMark.Size = new System.Drawing.Size(255, 26);
            this.txt_termworkMark.TabIndex = 6;
            // 
            // txt_failMArk
            // 
            this.txt_failMArk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_failMArk.Location = new System.Drawing.Point(229, 178);
            this.txt_failMArk.Name = "txt_failMArk";
            this.txt_failMArk.Size = new System.Drawing.Size(255, 26);
            this.txt_failMArk.TabIndex = 7;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(116, 243);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 34);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(197, 243);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(95, 34);
            this.btn_Update.TabIndex = 9;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(298, 243);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 34);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectidDataGridViewTextBoxColumn,
            this.subjetnameDataGridViewTextBoxColumn,
            this.semDataGridViewTextBoxColumn,
            this.twmarkDataGridViewTextBoxColumn,
            this.minmarkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.subjectsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(506, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(367, 243);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // subjectidDataGridViewTextBoxColumn
            // 
            this.subjectidDataGridViewTextBoxColumn.DataPropertyName = "subject_id";
            this.subjectidDataGridViewTextBoxColumn.HeaderText = "subject_id";
            this.subjectidDataGridViewTextBoxColumn.Name = "subjectidDataGridViewTextBoxColumn";
            this.subjectidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjetnameDataGridViewTextBoxColumn
            // 
            this.subjetnameDataGridViewTextBoxColumn.DataPropertyName = "subjet_name";
            this.subjetnameDataGridViewTextBoxColumn.HeaderText = "subjet_name";
            this.subjetnameDataGridViewTextBoxColumn.Name = "subjetnameDataGridViewTextBoxColumn";
            this.subjetnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // semDataGridViewTextBoxColumn
            // 
            this.semDataGridViewTextBoxColumn.DataPropertyName = "sem";
            this.semDataGridViewTextBoxColumn.HeaderText = "sem";
            this.semDataGridViewTextBoxColumn.Name = "semDataGridViewTextBoxColumn";
            this.semDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // twmarkDataGridViewTextBoxColumn
            // 
            this.twmarkDataGridViewTextBoxColumn.DataPropertyName = "tw_mark";
            this.twmarkDataGridViewTextBoxColumn.HeaderText = "tw_mark";
            this.twmarkDataGridViewTextBoxColumn.Name = "twmarkDataGridViewTextBoxColumn";
            this.twmarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minmarkDataGridViewTextBoxColumn
            // 
            this.minmarkDataGridViewTextBoxColumn.DataPropertyName = "min_mark";
            this.minmarkDataGridViewTextBoxColumn.HeaderText = "min_mark";
            this.minmarkDataGridViewTextBoxColumn.Name = "minmarkDataGridViewTextBoxColumn";
            this.minmarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "subjects";
            this.subjectsBindingSource.DataSource = this.studentMgtDataSet3;
            // 
            // studentMgtDataSet3
            // 
            this.studentMgtDataSet3.DataSetName = "StudentMgtDataSet3";
            this.studentMgtDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sem 1",
            "Sem 2",
            "Sem 3",
            "Sem 4",
            "Sem 5",
            "Sem 6",
            "Sem 7",
            "Sem 8"});
            this.comboBox1.Location = new System.Drawing.Point(229, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 305);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_failMArk);
            this.Controls.Add(this.txt_termworkMark);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_subjectName);
            this.Name = "AddSubject";
            this.Text = "AddSubject";
            this.Load += new System.EventHandler(this.AddSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMgtDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_subjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_termworkMark;
        private System.Windows.Forms.TextBox txt_failMArk;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private StudentMgtDataSet3 studentMgtDataSet3;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private StudentMgtDataSet3TableAdapters.subjectsTableAdapter subjectsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjetnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn twmarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minmarkDataGridViewTextBoxColumn;
    }
}
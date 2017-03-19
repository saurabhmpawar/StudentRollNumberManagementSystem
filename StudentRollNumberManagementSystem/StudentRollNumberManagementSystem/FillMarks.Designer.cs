namespace StudentRollNumberManagementSystem
{
    partial class FillMarks
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
            this.label_subject = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text_marks = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_pre = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rollnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentMgtDataSet2 = new StudentRollNumberManagementSystem.StudentMgtDataSet2();
            this.marks_detailsTableAdapter = new StudentRollNumberManagementSystem.StudentMgtDataSet2TableAdapters.marks_detailsTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSubjectid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMgtDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject :";
            // 
            // label_subject
            // 
            this.label_subject.AutoSize = true;
            this.label_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subject.Location = new System.Drawing.Point(167, 12);
            this.label_subject.Name = "label_subject";
            this.label_subject.Size = new System.Drawing.Size(0, 20);
            this.label_subject.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Roll Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Exam Seat No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Marks :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(208, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(204, 120);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 20);
            this.lbl_name.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(204, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 8;
            // 
            // text_marks
            // 
            this.text_marks.Location = new System.Drawing.Point(208, 189);
            this.text_marks.Name = "text_marks";
            this.text_marks.Size = new System.Drawing.Size(100, 20);
            this.text_marks.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Home ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(93, 247);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 37);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_pre
            // 
            this.btn_pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pre.Location = new System.Drawing.Point(258, 247);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(50, 37);
            this.btn_pre.TabIndex = 12;
            this.btn_pre.Text = "<";
            this.btn_pre.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(325, 247);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(48, 37);
            this.btn_next.TabIndex = 13;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Location = new System.Drawing.Point(174, 247);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 37);
            this.Btn_Delete.TabIndex = 14;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollnumberDataGridViewTextBoxColumn,
            this.subjectidDataGridViewTextBoxColumn,
            this.marksDataGridViewTextBoxColumn,
            this.createdOnDataGridViewTextBoxColumn,
            this.updatedOnDataGridViewTextBoxColumn,
            this.createdByDataGridViewTextBoxColumn,
            this.updatedByDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.marksdetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(427, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(335, 259);
            this.dataGridView1.TabIndex = 15;
            // 
            // rollnumberDataGridViewTextBoxColumn
            // 
            this.rollnumberDataGridViewTextBoxColumn.DataPropertyName = "roll_number";
            this.rollnumberDataGridViewTextBoxColumn.HeaderText = "roll_number";
            this.rollnumberDataGridViewTextBoxColumn.Name = "rollnumberDataGridViewTextBoxColumn";
            this.rollnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectidDataGridViewTextBoxColumn
            // 
            this.subjectidDataGridViewTextBoxColumn.DataPropertyName = "subject_id";
            this.subjectidDataGridViewTextBoxColumn.HeaderText = "subject_id";
            this.subjectidDataGridViewTextBoxColumn.Name = "subjectidDataGridViewTextBoxColumn";
            this.subjectidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marksDataGridViewTextBoxColumn
            // 
            this.marksDataGridViewTextBoxColumn.DataPropertyName = "marks";
            this.marksDataGridViewTextBoxColumn.HeaderText = "marks";
            this.marksDataGridViewTextBoxColumn.Name = "marksDataGridViewTextBoxColumn";
            this.marksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdOnDataGridViewTextBoxColumn
            // 
            this.createdOnDataGridViewTextBoxColumn.DataPropertyName = "createdOn";
            this.createdOnDataGridViewTextBoxColumn.HeaderText = "createdOn";
            this.createdOnDataGridViewTextBoxColumn.Name = "createdOnDataGridViewTextBoxColumn";
            this.createdOnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedOnDataGridViewTextBoxColumn
            // 
            this.updatedOnDataGridViewTextBoxColumn.DataPropertyName = "updatedOn";
            this.updatedOnDataGridViewTextBoxColumn.HeaderText = "updatedOn";
            this.updatedOnDataGridViewTextBoxColumn.Name = "updatedOnDataGridViewTextBoxColumn";
            this.updatedOnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdByDataGridViewTextBoxColumn
            // 
            this.createdByDataGridViewTextBoxColumn.DataPropertyName = "createdBy";
            this.createdByDataGridViewTextBoxColumn.HeaderText = "createdBy";
            this.createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
            this.createdByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedByDataGridViewTextBoxColumn
            // 
            this.updatedByDataGridViewTextBoxColumn.DataPropertyName = "updatedBy";
            this.updatedByDataGridViewTextBoxColumn.HeaderText = "updatedBy";
            this.updatedByDataGridViewTextBoxColumn.Name = "updatedByDataGridViewTextBoxColumn";
            this.updatedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marksdetailsBindingSource
            // 
            this.marksdetailsBindingSource.DataMember = "marks_details";
            this.marksdetailsBindingSource.DataSource = this.studentMgtDataSet2;
            // 
            // studentMgtDataSet2
            // 
            this.studentMgtDataSet2.DataSetName = "StudentMgtDataSet2";
            this.studentMgtDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marks_detailsTableAdapter
            // 
            this.marks_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Subject Id :";
            // 
            // lblSubjectid
            // 
            this.lblSubjectid.AutoSize = true;
            this.lblSubjectid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectid.Location = new System.Drawing.Point(182, 48);
            this.lblSubjectid.Name = "lblSubjectid";
            this.lblSubjectid.Size = new System.Drawing.Size(0, 20);
            this.lblSubjectid.TabIndex = 17;
            // 
            // FillMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 296);
            this.Controls.Add(this.lblSubjectid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_pre);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_marks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_subject);
            this.Controls.Add(this.label1);
            this.Name = "FillMarks";
            this.Text = "FillMarks";
            this.Load += new System.EventHandler(this.FillMarks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMgtDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_subject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_marks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_pre;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StudentMgtDataSet2 studentMgtDataSet2;
        private System.Windows.Forms.BindingSource marksdetailsBindingSource;
        private StudentMgtDataSet2TableAdapters.marks_detailsTableAdapter marks_detailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSubjectid;
    }
}
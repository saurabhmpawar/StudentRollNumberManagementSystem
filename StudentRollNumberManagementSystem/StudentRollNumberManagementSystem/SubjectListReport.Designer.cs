namespace StudentRollNumberManagementSystem
{
    partial class SubjectListReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.StudentMgtDataSetsubject = new StudentRollNumberManagementSystem.StudentMgtDataSetsubject();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsTableAdapter = new StudentRollNumberManagementSystem.StudentMgtDataSetsubjectTableAdapters.subjectsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StudentMgtDataSetsubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "subjectdatast";
            reportDataSource1.Value = this.subjectsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StudentRollNumberManagementSystem.SubjectAllList.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(946, 313);
            this.reportViewer1.TabIndex = 0;
            // 
            // StudentMgtDataSetsubject
            // 
            this.StudentMgtDataSetsubject.DataSetName = "StudentMgtDataSetsubject";
            this.StudentMgtDataSetsubject.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "subjects";
            this.subjectsBindingSource.DataSource = this.StudentMgtDataSetsubject;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // SubjectListReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 313);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SubjectListReport";
            this.Text = "SubjectListReport";
            this.Load += new System.EventHandler(this.SubjectListReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentMgtDataSetsubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private StudentMgtDataSetsubject StudentMgtDataSetsubject;
        private StudentMgtDataSetsubjectTableAdapters.subjectsTableAdapter subjectsTableAdapter;
    }
}
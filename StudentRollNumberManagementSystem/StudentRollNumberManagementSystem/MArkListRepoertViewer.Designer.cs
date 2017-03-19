namespace StudentRollNumberManagementSystem
{
    partial class MArkListRepoertViewer
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
            this.StudentMgtDataSet1 = new StudentRollNumberManagementSystem.StudentMgtDataSet1();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoTableAdapter = new StudentRollNumberManagementSystem.StudentMgtDataSet1TableAdapters.studentInfoTableAdapter();
            this.StudentMgtDataSet6 = new StudentRollNumberManagementSystem.StudentMgtDataSet6();
            this.ViewMarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ViewMarksTableAdapter = new StudentRollNumberManagementSystem.StudentMgtDataSet6TableAdapters.ViewMarksTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.StudentMgtDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentMgtDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewMarksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentMgtDataSet1
            // 
            this.StudentMgtDataSet1.DataSetName = "StudentMgtDataSet1";
            this.StudentMgtDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "studentInfo";
            this.studentInfoBindingSource.DataSource = this.StudentMgtDataSet1;
            // 
            // studentInfoTableAdapter
            // 
            this.studentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // StudentMgtDataSet6
            // 
            this.StudentMgtDataSet6.DataSetName = "StudentMgtDataSet6";
            this.StudentMgtDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ViewMarksBindingSource
            // 
            this.ViewMarksBindingSource.DataMember = "ViewMarks";
            this.ViewMarksBindingSource.DataSource = this.StudentMgtDataSet6;
            // 
            // ViewMarksTableAdapter
            // 
            this.ViewMarksTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ViewMarketDataset";
            reportDataSource1.Value = this.ViewMarksBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StudentRollNumberManagementSystem.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1217, 347);
            this.reportViewer1.TabIndex = 0;
            // 
            // MArkListRepoertViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 347);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MArkListRepoertViewer";
            this.Text = "MArkListRepoertViewer";
            this.Load += new System.EventHandler(this.MArkListRepoertViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentMgtDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentMgtDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewMarksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private StudentMgtDataSet1 StudentMgtDataSet1;
        private StudentMgtDataSet1TableAdapters.studentInfoTableAdapter studentInfoTableAdapter;
        private System.Windows.Forms.BindingSource ViewMarksBindingSource;
        private StudentMgtDataSet6 StudentMgtDataSet6;
        private StudentMgtDataSet6TableAdapters.ViewMarksTableAdapter ViewMarksTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
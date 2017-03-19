namespace StudentRollNumberManagementSystem
{
    partial class Sublistreport
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
            this.StudentMgtDataSet3 = new StudentRollNumberManagementSystem.StudentMgtDataSet3();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsTableAdapter = new StudentRollNumberManagementSystem.StudentMgtDataSet3TableAdapters.subjectsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StudentMgtDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "subjectDataSet";
            reportDataSource1.Value = this.subjectsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StudentRollNumberManagementSystem.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(637, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // StudentMgtDataSet3
            // 
            this.StudentMgtDataSet3.DataSetName = "StudentMgtDataSet3";
            this.StudentMgtDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "subjects";
            this.subjectsBindingSource.DataSource = this.StudentMgtDataSet3;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // Sublistreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Sublistreport";
            this.Text = "Sublistreport";
            this.Load += new System.EventHandler(this.Sublistreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentMgtDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private StudentMgtDataSet3 StudentMgtDataSet3;
        private StudentMgtDataSet3TableAdapters.subjectsTableAdapter subjectsTableAdapter;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;
namespace StudentRollNumberManagementSystem
{
    public partial class FillMarks : Form
    {

        int subjectInput = 0;
        int rollnoInput = 0;

        AddMarksInfo ownerForm = null;
        public FillMarks(AddMarksInfo ownerForm )
        {
            InitializeComponent();
            this.ownerForm= ownerForm;
            this.label_subject.Text=ownerForm.selectedValue;
            this.lblSubjectid.Text = ""+ownerForm.selectedSubjectid;
            fillSubjectCombo();
            DisplayData();
        }


        private void fillSubjectCombo()
        {
            try
            {
                SqlConnection con = DatabaseConnection.getDatabaseConnection();


                string query = "select roll_number from studentInfo where roll_number NOT IN (select roll_number from marks_details where subject_id=" + lblSubjectid.Text+")";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "roll_number");
                comboBox1.DisplayMember = "roll_number";
                comboBox1.ValueMember = "roll_number";
                comboBox1.DataSource = ds.Tables["roll_number"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }
        private void FillMarks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentMgtDataSet2.marks_details' table. You can move, or remove it, as needed.
            this.marks_detailsTableAdapter.Fill(this.studentMgtDataSet2.marks_details);

        }

        private void DisplayData()
        {
            SqlConnection con = DatabaseConnection.getDatabaseConnection();

            SqlDataAdapter adapt;

            con = DatabaseConnection.getDatabaseConnection();

            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from marks_details where subject_id="+lblSubjectid.Text, con);
            
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMarksInfo minfo = new AddMarksInfo();
            minfo.Show();
            this.Hide();
        }

        private void clearAll()
        {
            comboBox1.Text = "";
            text_marks.Clear();
            lbl_examSeatNo.Text = "";
            lbl_name.Text = "";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //	 INSERT INTO [dbo].[marks_details] ([roll_number], [subject_id], [marks], [createdOn], [updatedOn], [createdBy], [updatedBy]) 
//            VALUES(330, 1, 49, NULL, NULL, NULL, NULL)


            try
            {
                if(text_marks.Text!="" && comboBox1.Text!="")
                {
                    SqlConnection con = DatabaseConnection.getDatabaseConnection();

                    con = DatabaseConnection.getDatabaseConnection();

                    SqlCommand cmd = new SqlCommand("INSERT INTO marks_details (roll_number, subject_id, marks, createdOn, updatedOn, createdBy, updatedBy) VALUES (@roll_number, @subject_id, @marks, @createdOn, @updatedOn, @createdBy, @updatedBy)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@roll_number", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@subject_id",  lblSubjectid.Text);
                    cmd.Parameters.AddWithValue("@marks", text_marks.Text);                    
                    cmd.Parameters.AddWithValue("@createdOn", DateTime.Now);
                    cmd.Parameters.AddWithValue("@updatedOn", DateTime.Now);
                    cmd.Parameters.AddWithValue("@createdBy", "staff");
                    cmd.Parameters.AddWithValue("@updatedBy", "staff");

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DisplayData();
                    fillSubjectCombo();
                    clearAll();
                }
                else
                {
                    MessageBox.Show("Please Provide Details!");

                }
            }
            catch(Exception ws)
            {
                MessageBox.Show("opps error occured \n\n" + ws.GetBaseException());

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //select * from studentinfo where rollno = combobox1.txt

            try
            {
                SqlConnection con = DatabaseConnection.getDatabaseConnection();

                con = DatabaseConnection.getDatabaseConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("select *  from studentInfo where roll_number=@rollNo",con);

                cmd.Parameters.AddWithValue("@rollNo", comboBox1.Text);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lbl_name.Text= reader["name"].ToString();
                        lbl_examSeatNo.Text= reader["exam_seat_no"].ToString();
                        }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror Occured while fetching student resoard\n\n\n"+ex.GetBaseException());
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            rollnoInput = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            subjectInput = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());

            lblSubjectid.Text =""+ subjectInput;
            comboBox1.Text = ""+rollnoInput;
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (rollnoInput != 0 && subjectInput!=0)
            {
                SqlCommand cmd;
                SqlConnection con = DatabaseConnection.getDatabaseConnection();

                con = DatabaseConnection.getDatabaseConnection();

                cmd = new SqlCommand("delete marks_details where roll_number=@roll_number and subject_id=@subject_id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@roll_number", rollnoInput);
                cmd.Parameters.AddWithValue("@subject_id", subjectInput);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                fillSubjectCombo();
                clearAll();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
    }
}

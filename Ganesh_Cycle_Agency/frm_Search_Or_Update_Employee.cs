using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ganesh_Cycle_Agency
{
    public partial class frm_Search_Or_Update_Employee : Form
    {
        public frm_Search_Or_Update_Employee()
        {
            InitializeComponent();
        }


        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Ganesh_Cycle_Agency_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        void Clear_Controls()
        {
            tb_Employee_ID.Clear();
            tb_Employee_ID.Enabled = true;
            tb_Employee_Name.Clear();
            tb_Mobile_No_1.Clear();
            tb_Mobile_No_2.Clear();
            tb_Aadhaar_Card_No.Clear();
            dtp_Joining_Date.ResetText();
            tb_Designation.Clear();
            tb_Salary.Clear();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();
            SqlCommand cmd = new SqlCommand("Select * from Employee_Details where Employee_ID=@EID", Con);

            cmd.Parameters.Add("EID", SqlDbType.Int).Value = tb_Employee_ID.Text;
            SqlDataReader Dr = cmd.ExecuteReader();

            if (Dr.Read())
            {
                tb_Employee_Name.Text = Dr.GetString(Dr.GetOrdinal("Employee_Name"));
                tb_Mobile_No_1.Text = Dr["Mobile_No_1"].ToString();
                tb_Mobile_No_2.Text = Dr["Mobile_No_2"].ToString();
                tb_Designation.Text = Dr["Designation"].ToString();
                dtp_Joining_Date.Text = Dr["Joining_Date"].ToString();
                tb_Aadhaar_Card_No.Text = Dr["Aadhaar_Card_No"].ToString();
                tb_Salary.Text = Dr["Salary"].ToString();
                tb_Note.Text = Dr["Note"].ToString();
                tb_Employee_ID.Enabled = false;
            }
            else
            {
                MessageBox.Show("No Record found");
                tb_Employee_ID.Clear();

            }
            Con_Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = "Update Employee_Details set Employee_Name = @EName, Mobile_No_1 = @MNo1, Mobile_No_2 = @MNo2,Aadhaar_Card_No = @ACard, Joining_Date = @JDate,Designation =@Desig, Salary =@Sal  where Employee_ID = @EID";
            cmd.Parameters.Add("EID", SqlDbType.Int).Value = tb_Employee_ID.Text;
            cmd.Parameters.Add("EName", SqlDbType.VarChar).Value = tb_Employee_Name.Text;
            cmd.Parameters.Add("MNo1", SqlDbType.Decimal).Value = tb_Mobile_No_1.Text;
            cmd.Parameters.Add("MNo2", SqlDbType.Decimal).Value = tb_Mobile_No_2.Text;
            cmd.Parameters.Add("ACard", SqlDbType.Decimal).Value = tb_Aadhaar_Card_No.Text;
            cmd.Parameters.Add("JDate", SqlDbType.Date).Value = dtp_Joining_Date.Value.Date;
            cmd.Parameters.Add("Desig", SqlDbType.NVarChar).Value = tb_Designation.Text;
            cmd.Parameters.Add("Sal", SqlDbType.NVarChar).Value = tb_Salary.Text;

            cmd.ExecuteNonQuery();

            MessageBox.Show("Data Update Successfully.!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Con_Close(); 
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Employee obj = new frm_Employee();
            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }
    }
}
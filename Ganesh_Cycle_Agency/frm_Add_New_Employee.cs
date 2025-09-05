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
    public partial class frm_Add_New_Employee : Form
    {
        public frm_Add_New_Employee()
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

        int Auto_Incr()
        {
            int cnt = 0;

            Con_Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;

            cmd.CommandText = "Select Count(*) From Employee_Details";
            cnt = Convert.ToInt32(cmd.ExecuteScalar());

            if (cnt > 0)
            {
                cmd.CommandText = "Select Max(Employee_ID) From Employee_Details";
                cnt = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
            }
            else
            {
                cnt = 2001;
            }

            Con_Close();
            return cnt;
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;

            }
        }

        private void Only_TextDigit(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (char.IsDigit(e.KeyChar))))
            {
                e.Handled = true;

            }
        }

        void Clear_Controls()
        {
            tb_Employee_ID.Text = Convert.ToString(Auto_Incr());
            tb_Employee_Name.Clear();
            tb_Mobile_No_1.Clear();
            tb_Mobile_No_2.Clear();
            tb_Designation.Clear();
            dtp_Joining_Date.ResetText();
            tb_Aadhar_Card_No.Clear();
            tb_Salary.Clear();
            tb_Note.Clear();
        }


        private void frm_Add_New_Employee_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            
            Con_Open();

            if (tb_Employee_ID.Text!= "" && tb_Employee_Name.Text != ""&& tb_Mobile_No_1.Text !="" && tb_Mobile_No_2.Text !="" && tb_Designation.Text !=""&& tb_Aadhar_Card_No.Text!=""  && tb_Salary.Text!="")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Con;
                cmd.CommandText = "Insert Into Employee_Details(Employee_ID,Employee_Name,Mobile_No_1,Mobile_No_2,Designation,Joining_Date,Aadhaar_Card_No,Salary,Note)values(@EID,@EName,@MNo1,@MNo2,@Desg,@JDate,@Aadhaar,@Salary,@Note)";
                cmd.Parameters.Add("EID", SqlDbType.Int).Value = tb_Employee_ID.Text;
                cmd.Parameters.Add("EName", SqlDbType.VarChar).Value = tb_Employee_Name.Text;
                cmd.Parameters.Add("MNo1", SqlDbType.Decimal).Value = tb_Mobile_No_1.Text;
                cmd.Parameters.Add("MNo2", SqlDbType.Decimal).Value = tb_Mobile_No_2.Text;
                cmd.Parameters.Add("Desg", SqlDbType.NVarChar).Value = tb_Designation.Text;
                cmd.Parameters.Add("JDate", SqlDbType.Date).Value = dtp_Joining_Date.Value.Date;
                cmd.Parameters.Add("Aadhaar", SqlDbType.Decimal).Value = tb_Aadhar_Card_No.Text;
                cmd.Parameters.Add("Salary", SqlDbType.Money).Value = tb_Salary.Text;
                cmd.Parameters.Add("Note", SqlDbType.NVarChar).Value = tb_Note.Text;


                cmd.ExecuteNonQuery();

                MessageBox.Show("Record inserted successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First fill all fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
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

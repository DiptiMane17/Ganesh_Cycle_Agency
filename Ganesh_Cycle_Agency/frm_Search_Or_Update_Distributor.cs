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
    public partial class frm_Search_Or_Update_Distributor : Form
    {
        public frm_Search_Or_Update_Distributor()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Ganesh_Cycle_App_DB;Integrated Security=True");

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

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        void Clear_Controls()
        {
            tb_Distributor_ID.Clear();
            tb_Distributor_ID.Enabled = true;
            tb_Distributor_Name.Clear();
            tb_Mobile_No_1.Clear();
            tb_Mobile_No_2.Clear();
            tb_Email_ID.Clear();
            tb_Aadhar_Card_No.Clear();
            dtp_Date.ResetText();
            tb_PAN_Card.Clear();
            tb_Brand.Clear();
            tb_Note.Clear();
           

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            {
                Con_Open();
                SqlCommand cmd = new SqlCommand("Select * from Distributor_Details where Distributor_ID=@DID", Con);

                cmd.Parameters.Add("DID", SqlDbType.Int).Value = tb_Distributor_ID.Text;
                SqlDataReader Dr = cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Distributor_Name.Text = Dr.GetString(Dr.GetOrdinal("Distributor_Name"));
                    tb_Mobile_No_1.Text = Dr["Mobile_No_1"].ToString();
                    tb_Mobile_No_2.Text = Dr["Mobile_No_2"].ToString();
                    tb_Email_ID.Text = Dr.GetString(Dr.GetOrdinal("Email_ID"));
                    tb_Aadhar_Card_No.Text = Dr["Aadhaar_Card_No"].ToString();
                    dtp_Date.Text = Dr["Tie_Up_Date"].ToString();
                    tb_PAN_Card.Text = Dr.GetString(Dr.GetOrdinal("PAN_Card"));
                    tb_Brand.Text = Dr.GetString(Dr.GetOrdinal("Brand"));
                    tb_Note.Text = Dr.GetString(Dr.GetOrdinal("Note"));

                    tb_Distributor_ID.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No Record found");
                    tb_Distributor_ID.Clear();

                }
                Con_Close();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = "Update Distributor_Details set Distributor_Name = @Name, Mobile_No_1 = @MNo1, Mobile_No_2 = @MNo2, Email_ID = @EID, Aadhaar_Card_No = @ACard, Tie_UP_Date = @Date, PAN_Card = @PCard, Brand = @Brand, Note = @Note where Distributor_ID = @DID";
            cmd.Parameters.Add("DID", SqlDbType.Int).Value = tb_Distributor_ID.Text;
            cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = tb_Distributor_Name.Text;
            cmd.Parameters.Add("MNo1", SqlDbType.Decimal).Value = tb_Mobile_No_1.Text;
            cmd.Parameters.Add("MNo2", SqlDbType.Decimal).Value = tb_Mobile_No_2.Text;
            cmd.Parameters.Add("EID", SqlDbType.NVarChar).Value = tb_Email_ID.Text;
            cmd.Parameters.Add("ACard", SqlDbType.Decimal).Value = tb_Aadhar_Card_No.Text;
            cmd.Parameters.Add("Date", SqlDbType.Date).Value = dtp_Date.Value.Date;
            cmd.Parameters.Add("PCard", SqlDbType.NVarChar).Value = tb_PAN_Card.Text;
            cmd.Parameters.Add("Brand", SqlDbType.NVarChar).Value = tb_Brand.Text;
            cmd.Parameters.Add("Note", SqlDbType.NVarChar).Value = tb_Note.Text;

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Update Successfully !!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Con_Close(); 
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Distributor obj = new frm_Distributor();
            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure You Want to Logout ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                frm_Login obj = new frm_Login();
                obj.Show();
                this.Hide();
            }
        }
    }
}

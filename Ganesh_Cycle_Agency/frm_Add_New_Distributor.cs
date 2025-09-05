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
    public partial class frm_Add_New_Distributor : Form
    {
        public frm_Add_New_Distributor()
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

            cmd.CommandText = "Select Count(*) From Distributor_Details";
            cnt = Convert.ToInt32(cmd.ExecuteScalar());

            if (cnt > 0)
            {
                cmd.CommandText = "Select Max(Distributor_ID) From Distributor_Details";
                cnt = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
            }
            else
            {
                cnt = 3001;
            }

            Con_Close();
            return cnt;
        }
        void Clear_Controls()
        {
            tb_Distributor_ID.Text = Convert.ToString(Auto_Incr());
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
        private void frm_Add_New_Distributor_Load(object sender, EventArgs e)
        {
            Clear_Controls();
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
            if ((!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && !char.IsControl(e.KeyChar) && (char.IsSymbol(e.KeyChar))))
            {
                e.Handled = true;

            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Distributor_ID.Text != "" && tb_Distributor_Name.Text != "" && tb_Mobile_No_1.Text != "" && tb_Mobile_No_2.Text != "" && tb_Email_ID.Text != "" && tb_Aadhar_Card_No.Text != "" && tb_PAN_Card.Text != "" && tb_Brand.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Con;
                cmd.CommandText = "Insert Into Distributor_Details(Distributor_ID,Distributor_Name,Mobile_No_1,Mobile_No_2,Email_ID,Aadhaar_Card_No,Tie_Up_Date,PAN_Card,Brand,Note)values(@DID,@DName,@MNo1,@MNo2,@Email,@Aadhaar,@Date,@Pan,@Brand,@Note)";
                cmd.Parameters.Add("DID", SqlDbType.Int).Value = tb_Distributor_ID.Text;
                cmd.Parameters.Add("DName", SqlDbType.VarChar).Value = tb_Distributor_Name.Text;
                cmd.Parameters.Add("MNo1", SqlDbType.Decimal).Value = tb_Mobile_No_1.Text;
                cmd.Parameters.Add("MNo2", SqlDbType.Decimal).Value = tb_Mobile_No_2.Text;
                cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = tb_Email_ID.Text;
                cmd.Parameters.Add("Aadhaar", SqlDbType.Decimal).Value = tb_Aadhar_Card_No.Text;
                cmd.Parameters.Add("Date", SqlDbType.Date).Value = dtp_Date.Value.Date;
                cmd.Parameters.Add("Pan", SqlDbType.NVarChar).Value = tb_PAN_Card.Text;
                cmd.Parameters.Add("Brand", SqlDbType.NVarChar).Value = tb_Brand.Text;
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

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void frm_Add_New_Distributor_Load_1(object sender, EventArgs e)
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
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }
    }
}

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
    public partial class frm_Registration : Form
    {
        public frm_Registration()
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
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            tb_Username.Clear();
            tb_Password.Clear();
            tb_ReEnter_Password.Clear();
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Username.Text !="" && tb_Password.Text !="" && tb_ReEnter_Password.Text !="" && tb_Password.Text == tb_ReEnter_Password.Text)
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Con;
                cmd.CommandText = "Insert Into Login_Details(Name,Mobile_No,Username,Password,ReEnter_Password)values(@Nm,@MNo,@UName,@Pass,@Repass)";

                cmd.Parameters.Add("Nm", SqlDbType.NVarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                cmd.Parameters.Add("UName", SqlDbType.NVarChar).Value =tb_Username.Text;
                cmd.Parameters.Add("Pass", SqlDbType.NVarChar).Value = tb_Password.Text;
                cmd.Parameters.Add("Repass", SqlDbType.NVarChar).Value = tb_ReEnter_Password.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Registration Successful...!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
                frm_Login obj = new frm_Login();
                obj.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("First fill all fields or Password didn't match ....", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Con_Close();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

    }
}

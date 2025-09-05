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
    public partial class frm_View_All_Employee : Form
    {
        public frm_View_All_Employee()
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
        void Bind_Grid(string Query)
        {
            Con_Open();
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_View_Employee.DataSource = dt;
            Con_Close();
        }

        private void frm_View_All_Employee_Load(object sender, EventArgs e)
        {
            Bind_Grid("Select * from Employee_Details");
        }

        void Clear_Control()
        {
            cmb_Search_By.SelectedIndex = -1;
            tb_Search.Clear();
        }
        Boolean Flag;
        private void smb_Search_By_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_Search.Clear();
            if (cmb_Search_By.SelectedIndex == 0)
            {
                Flag = false;
            }
            else if (cmb_Search_By.SelectedIndex == 1)
            {
                Flag = true;
            }
            tb_Search.Enabled = true;
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            if (Flag == false)
            {
                Bind_Grid("Select * From Employee_Details where Employee_ID like '" + tb_Search.Text + "%'");

            }
            else if (Flag == true)
            {
                Bind_Grid("Select * From Employee_Details where Employee_Name like '" + tb_Search.Text + "%'");
            }
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Employee obj = new frm_Employee();
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

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ganesh_Cycle_Agency.Reports.Forms
{
    public partial class frm_Distributor_Reports_Name : Form
    {
        public frm_Distributor_Reports_Name()
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
        void Bind_Report(string name)
        {
            Con_Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("sp_Distributor_Report_Name", Con);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Cat", name);

            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            Con_Close();

            Ganesh_Cycle_Agency.Reports.cr_Distributor_Reports_Name cr_Cust = new Ganesh_Cycle_Agency.Reports.cr_Distributor_Reports_Name();
            cr_Cust.Database.Tables["sp_Distributor_Report_Name"].SetDataSource(dtbl);
            crv_Distributor_Reports.ReportSource = null;

            crv_Distributor_Reports.ReportSource = cr_Cust;
        }
        private void frm_Distributor_Reports_Name_Load(object sender, EventArgs e)
        {
            Bind_Report(tb_Distributor_Name.Text);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Bind_Report(tb_Distributor_Name.Text);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Reports obj = new frm_Reports();
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

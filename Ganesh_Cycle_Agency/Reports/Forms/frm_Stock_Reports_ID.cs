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
    public partial class frm_Stock_Reports_ID : Form
    {
        public frm_Stock_Reports_ID()
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

        void Bind_Report(string id)
        {
            Con_Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("sp_Stock_Report_ID", Con);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Cat", id);

            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            Con_Close();

            Ganesh_Cycle_Agency.Reports.cr_Stock_Reports_ID cr_Cust = new Ganesh_Cycle_Agency.Reports.cr_Stock_Reports_ID();
            cr_Cust.Database.Tables["sp_Stock_Report_ID"].SetDataSource(dtbl);
            crv_Stock_Report_ID.ReportSource = null;

            crv_Stock_Report_ID.ReportSource = cr_Cust;
        }
        private void frm_Stock_Reports_ID_Load(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Bind_Report(tb_Product_ID.Text);
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
